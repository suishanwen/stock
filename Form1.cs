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
using System.Threading;

namespace stock
{
    public partial class Form1 : Form
    {
        private Thread main;    //主线程
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
            initConfig();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            main = new Thread(getAllTicker);
            main.Start();
        }
        private void initConfig()
        {
            String stock1 = IniReadWriter.ReadIniKeys("stock", "stock1", "./CF.ini");
            String stock2 = IniReadWriter.ReadIniKeys("stock", "stock1", "./CF.ini");
            String stock3 = IniReadWriter.ReadIniKeys("stock", "stock1", "./CF.ini");
            String stock4 = IniReadWriter.ReadIniKeys("stock", "stock1", "./CF.ini");
            String stock5 = IniReadWriter.ReadIniKeys("stock", "stock1", "./CF.ini");
            String stock6 = IniReadWriter.ReadIniKeys("stock", "stock1", "./CF.ini");
            String cost1 = IniReadWriter.ReadIniKeys("stock", "cost1", "./CF.ini");
            String cost2 = IniReadWriter.ReadIniKeys("stock", "cost2", "./CF.ini");
            String cost3 = IniReadWriter.ReadIniKeys("stock", "cost3", "./CF.ini");
            String cost4 = IniReadWriter.ReadIniKeys("stock", "cost4", "./CF.ini");
            String cost5 = IniReadWriter.ReadIniKeys("stock", "cost5", "./CF.ini");
            String cost6 = IniReadWriter.ReadIniKeys("stock", "cost6", "./CF.ini");
            String quantity1 = IniReadWriter.ReadIniKeys("stock", "quantity1", "./CF.ini");
            String quantity2 = IniReadWriter.ReadIniKeys("stock", "quantity2", "./CF.ini");
            String quantity3 = IniReadWriter.ReadIniKeys("stock", "quantity3", "./CF.ini");
            String quantity4 = IniReadWriter.ReadIniKeys("stock", "quantity4", "./CF.ini");
            String quantity5 = IniReadWriter.ReadIniKeys("stock", "quantity5", "./CF.ini");
            String quantity6 = IniReadWriter.ReadIniKeys("stock", "quantity6", "./CF.ini");
            name1=IniReadWriter.ReadIniKeys("stock", "name1", "./CF.ini");
            name2 = IniReadWriter.ReadIniKeys("stock", "name2", "./CF.ini");
            name3 = IniReadWriter.ReadIniKeys("stock", "name3", "./CF.ini");
            name4 = IniReadWriter.ReadIniKeys("stock", "name4", "./CF.ini");
            name5 = IniReadWriter.ReadIniKeys("stock", "name5", "./CF.ini");
            name6 = IniReadWriter.ReadIniKeys("stock", "name6", "./CF.ini");
            price1 = IniReadWriter.ReadIniKeys("stock", "price1", "./CF.ini");
            price2 = IniReadWriter.ReadIniKeys("stock", "price2", "./CF.ini");
            price3 = IniReadWriter.ReadIniKeys("stock", "price3", "./CF.ini");
            price4 = IniReadWriter.ReadIniKeys("stock", "price4", "./CF.ini");
            price5 = IniReadWriter.ReadIniKeys("stock", "price5", "./CF.ini");
            price6 = IniReadWriter.ReadIniKeys("stock", "price6", "./CF.ini");
            String percentage1 = IniReadWriter.ReadIniKeys("stock", "percentage1", "./CF.ini");
            String percentage2 = IniReadWriter.ReadIniKeys("stock", "percentage2", "./CF.ini");
            String percentage3 = IniReadWriter.ReadIniKeys("stock", "percentage4", "./CF.ini");
            String percentage4 = IniReadWriter.ReadIniKeys("stock", "percentage5", "./CF.ini");
            String percentage5 = IniReadWriter.ReadIniKeys("stock", "percentage6", "./CF.ini");
            String percentage6 = IniReadWriter.ReadIniKeys("stock", "percentage7", "./CF.ini");
            String shares1 = IniReadWriter.ReadIniKeys("stock", "shares1", "./CF.ini");
            String shares2 = IniReadWriter.ReadIniKeys("stock", "shares2", "./CF.ini");
            String shares3 = IniReadWriter.ReadIniKeys("stock", "shares3", "./CF.ini");
            String shares4 = IniReadWriter.ReadIniKeys("stock", "shares4", "./CF.ini");
            String shares5 = IniReadWriter.ReadIniKeys("stock", "shares5", "./CF.ini");
            String shares6 = IniReadWriter.ReadIniKeys("stock", "shares6", "./CF.ini");
            String allCosts = IniReadWriter.ReadIniKeys("stock", "allCosts", "./CF.ini");
            String marketValue = IniReadWriter.ReadIniKeys("stock", "marketValue", "./CF.ini");
            String totalPercentage = IniReadWriter.ReadIniKeys("stock", "totalPercentage", "./CF.ini");
            String totalShares = IniReadWriter.ReadIniKeys("stock", "totalShares", "./CF.ini");

            StringUtil.setText(textBox1, stock1);
            StringUtil.setText(textBox2, stock2);
            StringUtil.setText(textBox3, stock3);
            StringUtil.setText(textBox4, stock4);
            StringUtil.setText(textBox5, stock5);
            StringUtil.setText(textBox6, stock6);
            StringUtil.setText(textBox7, cost1);
            StringUtil.setText(textBox8, cost2);
            StringUtil.setText(textBox9, cost3);
            StringUtil.setText(textBox10, cost4);
            StringUtil.setText(textBox11, cost5);
            StringUtil.setText(textBox12, cost6);
            StringUtil.setText(textBox13, quantity1);
            StringUtil.setText(textBox14, quantity2);
            StringUtil.setText(textBox15, quantity3);
            StringUtil.setText(textBox16, quantity4);
            StringUtil.setText(textBox17, quantity5);
            StringUtil.setText(textBox18, quantity6);

            StringUtil.setLabel(label1, name1);
            StringUtil.setLabel(label2, name2);
            StringUtil.setLabel(label3, name3);
            StringUtil.setLabel(label4, name4);
            StringUtil.setLabel(label5, name5);
            StringUtil.setLabel(label6, name6);


            StringUtil.setLabel(label7, price1);
            StringUtil.setLabel(label8, price2);
            StringUtil.setLabel(label9, price3);
            StringUtil.setLabel(label10, price4);
            StringUtil.setLabel(label11, price5);
            StringUtil.setLabel(label12, price6);
            StringUtil.setLabel(label13, percentage1);
            StringUtil.setLabel(label14, percentage2);
            StringUtil.setLabel(label15, percentage3);
            StringUtil.setLabel(label16, percentage4);
            StringUtil.setLabel(label17, percentage5);
            StringUtil.setLabel(label18, percentage6);
            StringUtil.setLabel(label19, shares1);
            StringUtil.setLabel(label20, shares2);
            StringUtil.setLabel(label21, shares3);
            StringUtil.setLabel(label22, shares4);
            StringUtil.setLabel(label23, shares5);
            StringUtil.setLabel(label24, shares6);
            StringUtil.setLabel(label26, allCosts);
            StringUtil.setLabel(label28, marketValue);
            StringUtil.setLabel(label30, totalPercentage);
            StringUtil.setLabel(label31, totalShares);

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
            try
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

                IniReadWriter.WriteIniKeys("stock", "name1", name1, "./CF.ini");
                IniReadWriter.WriteIniKeys("stock", "price1", price1, "./CF.ini");

                IniReadWriter.WriteIniKeys("stock", "name2", name2, "./CF.ini");
                IniReadWriter.WriteIniKeys("stock", "price2", price2, "./CF.ini");

                IniReadWriter.WriteIniKeys("stock", "name3", name3, "./CF.ini");
                IniReadWriter.WriteIniKeys("stock", "price3", price3, "./CF.ini");

                IniReadWriter.WriteIniKeys("stock", "name4", name4, "./CF.ini");
                IniReadWriter.WriteIniKeys("stock", "price4", price4, "./CF.ini");

                IniReadWriter.WriteIniKeys("stock", "name5", name5, "./CF.ini");
                IniReadWriter.WriteIniKeys("stock", "price5", price5, "./CF.ini");

                IniReadWriter.WriteIniKeys("stock", "name6", name6, "./CF.ini");
                IniReadWriter.WriteIniKeys("stock", "price6", price6, "./CF.ini");
            }
            catch(Exception)
            {

            }
            finally
            {
                Thread.Sleep(5000);
                getAllTicker();
            }
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
            label19.Text = getTickerShares(float.Parse(textBox7.Text), float.Parse(price1), int.Parse(textBox13.Text));
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

            IniReadWriter.WriteIniKeys("stock", "percentage1", label13.Text, "./CF.ini");
            IniReadWriter.WriteIniKeys("stock", "shares1", label19.Text, "./CF.ini");

            IniReadWriter.WriteIniKeys("stock", "percentage2", label14.Text, "./CF.ini");
            IniReadWriter.WriteIniKeys("stock", "shares2", label20.Text, "./CF.ini");

            IniReadWriter.WriteIniKeys("stock", "percentage3", label15.Text, "./CF.ini");
            IniReadWriter.WriteIniKeys("stock", "shares3", label21.Text, "./CF.ini");

            IniReadWriter.WriteIniKeys("stock", "percentage4", label16.Text, "./CF.ini");
            IniReadWriter.WriteIniKeys("stock", "shares4", label22.Text, "./CF.ini");

            IniReadWriter.WriteIniKeys("stock", "percentage5", label17.Text, "./CF.ini");
            IniReadWriter.WriteIniKeys("stock", "shares5", label23.Text, "./CF.ini");

            IniReadWriter.WriteIniKeys("stock", "percentage6", label18.Text, "./CF.ini");
            IniReadWriter.WriteIniKeys("stock", "shares6", label24.Text, "./CF.ini");


            IniReadWriter.WriteIniKeys("stock", "allCosts", label26.Text, "./CF.ini");
            IniReadWriter.WriteIniKeys("stock", "marketValue", label28.Text, "./CF.ini");
            IniReadWriter.WriteIniKeys("stock", "totalPercentage", label30.Text, "./CF.ini");
            IniReadWriter.WriteIniKeys("stock", "totalShares", label31.Text, "./CF.ini");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            IniReadWriter.WriteIniKeys("stock", "stock1", textBox1.Text, "./CF.ini");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            IniReadWriter.WriteIniKeys("stock", "stock2", textBox2.Text, "./CF.ini");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            IniReadWriter.WriteIniKeys("stock", "stock3", textBox3.Text, "./CF.ini");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            IniReadWriter.WriteIniKeys("stock", "stock4", textBox4.Text, "./CF.ini");
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            IniReadWriter.WriteIniKeys("stock", "stock5", textBox5.Text, "./CF.ini");
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            IniReadWriter.WriteIniKeys("stock", "stock6", textBox6.Text, "./CF.ini");
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            IniReadWriter.WriteIniKeys("stock", "cost1", textBox7.Text, "./CF.ini");
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            IniReadWriter.WriteIniKeys("stock", "cost2", textBox8.Text, "./CF.ini");
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            IniReadWriter.WriteIniKeys("stock", "cost3", textBox9.Text, "./CF.ini");
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            IniReadWriter.WriteIniKeys("stock", "cost4", textBox10.Text, "./CF.ini");
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            IniReadWriter.WriteIniKeys("stock", "cost5", textBox11.Text, "./CF.ini");
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            IniReadWriter.WriteIniKeys("stock", "cost6", textBox12.Text, "./CF.ini");
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            IniReadWriter.WriteIniKeys("stock", "quantity1", textBox13.Text, "./CF.ini");
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            IniReadWriter.WriteIniKeys("stock", "quantity2", textBox14.Text, "./CF.ini");
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            IniReadWriter.WriteIniKeys("stock", "quantity3", textBox15.Text, "./CF.ini");
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            IniReadWriter.WriteIniKeys("stock", "quantity4", textBox16.Text, "./CF.ini");
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            IniReadWriter.WriteIniKeys("stock", "quantity5", textBox17.Text, "./CF.ini");
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            IniReadWriter.WriteIniKeys("stock", "quantity6", textBox18.Text, "./CF.ini");
        }
    }
}
