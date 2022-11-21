using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BotIskra
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer balansT = new Timer();
        private System.Windows.Forms.Timer statTimer = new Timer();
        private ApiPrivate api = null;
        private Random rnd = new Random();
        private bool work = false;
        private decimal btc = 0;
        private decimal ccoh = 0;
        private decimal minTrade = 0;
        private decimal maxTrade = 0;
        private DateTime timestart;
        public Form1()
        {
            InitializeComponent();

            BotIskra.Main.Init();
            this.Text = "IskraBot v1.8";
            timestart = DateTime.Now;
           
            this.Icon = Properties.Resources.icon;

            listView1.View = System.Windows.Forms.View.Details;
            listView1.LabelEdit = false;
            listView1.AllowColumnReorder = false;
            listView1.FullRowSelect = true;
            listView1.HeaderStyle = ColumnHeaderStyle.None;
            listView1.GridLines = true;
            listView1.Columns.Add("1", 80);
            listView1.Columns.Add("2", 60);
            listView1.Columns.Add("3", 80);
            listView1.Columns.Add("4", 60);
            listView1.Columns.Add("5", 50);
            listView1.Columns.Add("6", 80);
            listView1.Columns.Add("7", 60);
            workStat.Text = "Status: Stop";

            balansT.Tick += BalansT_Tick;
            statTimer.Interval = 1;
            statTimer.Tick += StatTimer_Tick;
            
            try
            {
                api = new ApiPrivate(BotIskra.Main.Configuration["WhitebitSettings:ApiKey"], BotIskra.Main.Configuration["WhitebitSettings:ApiSecret"]);
                //api = new Api("c7d3333da9c300efadf1d5b64f572a20", "005a5473d9ed4c5df475d5e4926a7f75");
                connectionStat.Text = "Connetciong: OK";
                //listView1.Items.Add(new ListViewItem(new string[] { "Connecting", "OK" }));
                
                BalansT_Tick(new object(), new EventArgs());

                // api.CreateOrder(0, 1);
             
            }
            catch
            {
                //listView1.Items.Add(new ListViewItem(new string[] { "Connecting", "FAIL" }));
                 connectionStat.Text = "Connetciong: FAIL";
                Start.Enabled = false;
                api = null;
            }
            
        }

        private void StatTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                if(timerStat.Value + 1 < timerStat.Maximum)
                    timerStat.Value += 1;
            }
            catch {
                //timerStat.Value = timerStat.Maximum;
            }
        }

        private void BalansT_Tick(object sender, EventArgs e)
        {
            if (api != null)
            {
                Bal();
                Trade();
            }
        }

        public async void Bal()
        {
            ModelsPrivate.TrateBalance Balance = await api.GetMainBalance();
            if (Balance == null)
                Bal();
            try
            {
                btc = Convert.ToDecimal(Balance.BTC.available.Replace(".", ","));
                ccoh = Convert.ToDecimal(Balance.CCOH.available.Replace(".", ","));
                ViewBalance();
            }
            catch { }
        }

        public async void Trade()
        {
            try
            {
                var pairs = ApiPublic.GetPairs();
                var ccoh_btc = pairs.Where(x => x.tradingPairs == "CCOH_BTC" & x.tradesEnabled).First();         
                maxTrade = Convert.ToDecimal(ccoh_btc.highestBid.Replace(".", ","));
                minTrade = Convert.ToDecimal(ccoh_btc.lowestAsk.Replace(".", ","));
            }
            catch (Exception ex)
            {
                
            }
            ViewBalance();
        }
        private void ViewBalance()
        {
            bal_btc.Text = btc.ToString();
            bal_ccoh.Text = ccoh.ToString();
            ccohMax.Text = maxTrade.ToString() ;
            ccohMin.Text =  minTrade.ToString();
            if (TradeMax.Text == "" && TradeMin.Text == "")
            {
                TradeMax.Text = (maxTrade- (maxTrade /100)*1).ToString();
                TradeMin.Text = (minTrade+ (maxTrade / 100) * 1).ToString();
            }       
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TradeMin.Enabled = false;
            TradeMax.Enabled = false;
            double tim = (double)Convert.ToDouble(BotIskra.Main.Configuration["AppSettings:FirstTrade"].Replace(".",","))*60000;
            balansT.Stop();
            balansT.Interval = 70000;
            balansT.Start();

            timerStat.Maximum = (int)tim/16 ;
            statTimer.Start();

            listView1.Items.Add(new ListViewItem(new string[] { "Withdraw in:", Math.Round((tim/60000),1).ToString() + " min." }));

            ViewBalance();
           
            timer.Interval = (int)(tim);
            
            workStat.Text = "Status:Work";
            timer.Tick += Timer_Tick;
            timer.Start();
            Start.Enabled = false;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            
            double tim = 0;
            int pause = Convert.ToInt32(BotIskra.Main.Configuration["AppSettings:PauseThrough"]);
            if (timestart.AddMinutes(pause) > DateTime.Now)
                tim = rnd.Next(Convert.ToInt32( BotIskra.Main.Configuration["AppSettings:MinIntervalTrade"])*60000, Convert.ToInt32( BotIskra.Main.Configuration["AppSettings:MaxIntervalTrade"])*60000);
            else
            {
                tim = rnd.Next(Convert.ToInt32(BotIskra.Main.Configuration["AppSettings:PauseIntervalMin"]), Convert.ToInt32(BotIskra.Main.Configuration["AppSettings:PauseIntervalMax"]));
                timestart = DateTime.Now;
            }

            timer.Interval = (int)(tim );

            try
            {
                timerStat.Maximum = (int)tim/16;
                timerStat.Value = 0;
            }
            catch { }

            string buy_sell = "buy";
            int rnd_ = rnd.Next(0, 10);
            if (rnd_ > 5)
                buy_sell = "sell";
            decimal trade = 0;

            int ammount = rnd.Next(Convert.ToInt32(BotIskra.Main.Configuration["AppSettings:MinAmmount"]), Convert.ToInt32(BotIskra.Main.Configuration["AppSettings:MaxAmmount"]));
            if (maxTrade < Convert.ToDecimal(TradeMax.Text) && buy_sell == "sell" )
            {
                //if (buy_sell == 0) trade = minTrade; else trade = maxTrade;
                listView1.Items[listView1.Items.Count - 1].SubItems.Add("LIMIT PASS");
            }
            else if  (minTrade > Convert.ToDecimal(TradeMin.Text) && buy_sell == "buy")
            {
                //if (buy_sell == 0) trade = Convert.ToDecimal(TradeMin.Text); else trade = Convert.ToDecimal(TradeMax.Text);
                listView1.Items[listView1.Items.Count - 1].SubItems.Add("LIMIT PASS");
            }
            else
            {
                if (buy_sell == "buy") trade = Convert.ToDecimal(ccohMin.Text); else trade = Convert.ToDecimal(ccohMax.Text);
                Task<ModelsPrivate.MainHistory> res = api.CreateOrder(ammount, buy_sell, trade);
                //Task<ModelsPrivate.MainHistory> res = null;
                if (res != null)
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add("OK");
                else
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add("FAIL");
            }
            
            
            listView1.Items[listView1.Items.Count - 1].SubItems.Add(buy_sell);
            listView1.Items[listView1.Items.Count - 1].SubItems.Add(ammount.ToString());
            listView1.Items[listView1.Items.Count - 1].SubItems.Add(trade.ToString());
            listView1.Items[listView1.Items.Count - 1].SubItems.Add(DateTime.Now.ToString("HH:mm:ss"));

            listView1.Items.Add(new ListViewItem(new string[] { "Withdraw in: ", Math.Round((tim/60000),1).ToString() + " min." }));
                        
        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer.Stop();
            listView1.Items.Add(new ListViewItem(new string[] { "Timer : ", "Stop" }));
            timer.Tick -= Timer_Tick;
            workStat.Text = "Status:Stop";
            statTimer.Stop();
            timerStat.Value = 0;

            TradeMin.Enabled = true;
            TradeMax.Enabled = true;
            Start.Enabled = true;
        }
    }
}
