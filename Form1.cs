using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using stock.util;
namespace stock
{
    public partial class Form1 : Form
    {
        private String url_prex = "http://hq.sinajs.cn";
        private const String TICKER_URL = "/";
        private String name1;
        private String price1;
        private String name2;
        private String price2;
        private String name3;
        private String price3;
        private String name4;
        private String price4;
        private String name5;
        private String price5;
        private String name6;
        private String price6;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }


        private String getTickerShares(float buyPrice, float currentPrice,int quantity)
        {
            return (currentPrice - buyPrice) * quantity + "";
        }

        private String getTickerPercentage(float buyPrice, float currentPrice)
        {
            return (currentPrice - buyPrice) / buyPrice * 100 + "%";
        }

        private String getAllCosts()
        {
            float cost1 = float.Parse(textBox7.Text) * int.Parse(textBox13.Text);
            float cost2 = float.Parse(textBox8.Text) * int.Parse(textBox14.Text);
            float cost3 = float.Parse(textBox9.Text) * int.Parse(textBox15.Text);
            float cost4 = float.Parse(textBox10.Text) * int.Parse(textBox16.Text);
            float cost5 = float.Parse(textBox11.Text) * int.Parse(textBox17.Text);
            float cost6 = float.Parse(textBox12.Text) * int.Parse(textBox18.Text);
            return cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + "";
        }

        private String getCurrentMarketValue()
        {
            float value1 = float.Parse(label7.Text) * int.Parse(textBox13.Text);
            float value2 = float.Parse(label8.Text) * int.Parse(textBox14.Text);
            float value3 = float.Parse(label9.Text) * int.Parse(textBox15.Text);
            float value4 = float.Parse(label10.Text) * int.Parse(textBox16.Text);
            float value5 = float.Parse(label11.Text) * int.Parse(textBox17.Text);
            float value6 = float.Parse(label12.Text) * int.Parse(textBox18.Text);
            return value1 + value2 + value3 + value4 + value5 + value6 + "";
        }

        private String getTotalShares()
        {
            return float.Parse(label28.Text) - float.Parse(label26.Text)  + "";
        }

        private String getTotalPercentage()
        {
            return float.Parse(getTotalShares()) / float.Parse(label28.Text)*100 + "%";
        }

        private void getAllTicker()
        {
            String _ticker = ticker(textBox1.Text);
            String _tickerTemp = "";
            name1 = _ticker.Substring(_ticker.IndexOf("=") + 2, _ticker.IndexOf(",") - (_ticker.IndexOf("=") + 2));
            _tickerTemp = _ticker;
            for (int i = 0; i < 6; i++)
            {
                _tickerTemp = _tickerTemp.Substring(_tickerTemp.IndexOf(",") + 1);
            }
            price1 = _tickerTemp.Substring(0, _tickerTemp.IndexOf(","));
            _ticker = ticker(textBox2.Text);
            name2 = _ticker.Substring(_ticker.IndexOf("=") + 2, _ticker.IndexOf(",") - (_ticker.IndexOf("=") + 2));
            _tickerTemp = _ticker;
            for (int i = 0; i < 6; i++)
            {
                _tickerTemp = _tickerTemp.Substring(_tickerTemp.IndexOf(",") + 1);
            }
            price2 = _tickerTemp.Substring(0, _tickerTemp.IndexOf(","));
            _ticker = ticker(textBox3.Text);
            name3 = _ticker.Substring(_ticker.IndexOf("=") + 2, _ticker.IndexOf(",") - (_ticker.IndexOf("=") + 2));
            _tickerTemp = _ticker;
            for (int i = 0; i < 6; i++)
            {
                _tickerTemp = _tickerTemp.Substring(_tickerTemp.IndexOf(",") + 1);
            }
            price3 = _tickerTemp.Substring(0, _tickerTemp.IndexOf(","));
            _ticker = ticker(textBox4.Text);
            name4 = _ticker.Substring(_ticker.IndexOf("=") + 2, _ticker.IndexOf(",") - (_ticker.IndexOf("=") + 2));
            _tickerTemp = _ticker;
            for (int i = 0; i < 6; i++)
            {
                _tickerTemp = _tickerTemp.Substring(_tickerTemp.IndexOf(",") + 1);
            }
            price4 = _tickerTemp.Substring(0, _tickerTemp.IndexOf(","));
            _ticker = ticker(textBox5.Text);
            name5 = _ticker.Substring(_ticker.IndexOf("=") + 2, _ticker.IndexOf(",") - (_ticker.IndexOf("=") + 2));
            _tickerTemp = _ticker;
            for (int i = 0; i < 6; i++)
            {
                _tickerTemp = _tickerTemp.Substring(_tickerTemp.IndexOf(",") + 1);
            }
            price5 = _tickerTemp.Substring(0, _tickerTemp.IndexOf(","));
            _ticker = ticker(textBox6.Text);
            name6 = _ticker.Substring(_ticker.IndexOf("=") + 2, _ticker.IndexOf(",") - (_ticker.IndexOf("=") + 2));
            _tickerTemp = _ticker;
            for (int i = 0; i < 6; i++)
            {
                _tickerTemp = _tickerTemp.Substring(_tickerTemp.IndexOf(",") + 1);
            }
            price6 = _tickerTemp.Substring(0, _tickerTemp.IndexOf(","));

            label1.Text = name1;
            label2.Text = name2;
            label3.Text = name3;
            label4.Text = name4;
            label5.Text = name5;
            label6.Text = name6;

            label7.Text = price1;
            label8.Text = price2;
            label9.Text = price3;
            label10.Text = price4;
            label11.Text = price5;
            label12.Text = price6;

            label13.Text = getTickerPercentage(float.Parse(textBox7.Text), float.Parse(price1));
            label19.Text = getTickerShares(float.Parse(textBox7.Text), float.Parse(price1),int.Parse(textBox13.Text));
            label14.Text = getTickerPercentage(float.Parse(textBox8.Text), float.Parse(price2));
            label20.Text = getTickerShares(float.Parse(textBox8.Text), float.Parse(price2), int.Parse(textBox14.Text));
            label15.Text = getTickerPercentage(float.Parse(textBox9.Text), float.Parse(price3));
            label21.Text = getTickerShares(float.Parse(textBox9.Text), float.Parse(price3), int.Parse(textBox15.Text));
            label16.Text = getTickerPercentage(float.Parse(textBox10.Text), float.Parse(price4));
            label22.Text = getTickerShares(float.Parse(textBox10.Text), float.Parse(price4), int.Parse(textBox16.Text));
            label17.Text = getTickerPercentage(float.Parse(textBox11.Text), float.Parse(price5));
            label23.Text = getTickerShares(float.Parse(textBox11.Text), float.Parse(price5), int.Parse(textBox17.Text));
            label18.Text = getTickerPercentage(float.Parse(textBox12.Text), float.Parse(price6));
            label24.Text = getTickerShares(float.Parse(textBox12.Text), float.Parse(price6), int.Parse(textBox18.Text));

            label26.Text = getAllCosts();

            label28.Text = getCurrentMarketValue();

            label30.Text = getTotalPercentage();

            label31.Text = getTotalShares();

        }

        private String ticker(String symbol)
        {
            String result = "";
            try
            {
                HttpUtilManager httpUtil = HttpUtilManager.getInstance();
                String param = "";
                if (!StringUtil.isEmpty(symbol))
                {
                    if (!param.Equals(""))
                    {
                        param += "&";
                    }
                    if (symbol.Substring(0, 3) == "600")
                    {
                        symbol = "sh" + symbol;
                    } else{
                        symbol = "sz" + symbol;
                    }

                    param += "list=" + symbol;
                }
                result = httpUtil.requestHttpGet(url_prex, TICKER_URL, param);
            }
            catch (Exception e)
            {
                throw e;
            }
            return result;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            getAllTicker();
        }
    }
}
