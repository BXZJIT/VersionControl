using BXZJIT_5.GYAK.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BXZJIT_5.GYAK
{
    public partial class Form1 : Form
    {
       
        PortfolioEntities context = new PortfolioEntities();
        List<Tick> Ticks;
        List<Portfolioitem> Portfolio = new List<Portfolioitem>();
        List<decimal> Nyereségek = new List<decimal>();
        public Form1()
        {
            InitializeComponent();
            Ticks = context.Ticks.ToList();
            dataGridView1.DataSource = Ticks;
            CreatePortfolio();
            int intervalum = 30;
            DateTime kezdőDátum = (from x in Ticks select x.TradingDay).Min();
            DateTime záróDátum = new DateTime(2016, 12, 30);
            TimeSpan z = záróDátum - kezdőDátum;
            for (int i = 0; i < z.Days - intervalum; i++)
            {
                decimal ny = GetPortfolioValue(kezdőDátum.AddDays(i + intervalum))
                           - GetPortfolioValue(kezdőDátum.AddDays(i));
                Nyereségek.Add(ny);
                Console.WriteLine(i + " " + ny);
            }

            var nyereségekRendezve = (from x in Nyereségek
                                      orderby x
                                      select x)
                                        .ToList();

            
        }
        private void CreatePortfolio()
        {
            Portfolio.Add(new Portfolioitem() { Index = "OTP", Volume = 10 });
            Portfolio.Add(new Portfolioitem() { Index = "ZWACK", Volume = 10 });
            Portfolio.Add(new Portfolioitem() { Index = "ELMU", Volume = 10 });

            dataGridView2.DataSource = Portfolio;
        }
        private decimal GetPortfolioValue(DateTime date)
        {
            decimal value = 0;
            foreach (var item in Portfolio)
            {
                var last = (from x in Ticks
                            where item.Index == x.Index.Trim()
                               && date <= x.TradingDay
                            select x)
                            .First();
                value += (decimal)last.Price * item.Volume;
            }
            return value;
        }

        private void Save_Click(object sender, EventArgs e)
        {


            var nyereségekRendezve = (from x in Nyereségek
                                      orderby x
                                      select x)
                                       .ToList();

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = Application.StartupPath;
            sfd.Filter = "Comma Separated Values(*csv)|*.csv";
            sfd.DefaultExt = "csv";
            sfd.AddExtension = true;
            if (sfd.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
            {
                int i = 1;
                sw.Write("Időszak");
                sw.Write(";");
                sw.Write("Nyereség");
                sw.WriteLine();
                foreach (var p in nyereségekRendezve)
                {

                    sw.Write(i);
                    sw.Write(";");
                    sw.Write(p);
                    sw.WriteLine();
                    i++;
                }
            }
        }
    }
    
}
