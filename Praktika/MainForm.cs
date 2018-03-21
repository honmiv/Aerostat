using System;
using System.Drawing;
using System.Windows.Forms;

namespace praktika
{
	public partial class MainForm : Form
	{
		double[] densities = new double[20001]; // массив плотности воздуха на высотах от 0 до 2999
		double g = 9.80665; // ускорение свободного падния [м/c^2]
		int startY;
		int k = 0;
		bool stop = false;
		
		public MainForm()
		{
			InitializeComponent();
			imgBox.BackColor = Color.Transparent;
			startY=imgBox.Location.Y;
			draw(Convert.ToInt32(height.Text));
		}
				
		void draw (int h)
		{
			imgBox.Location = new Point(imgBox.Location.X,startY - (int)(h*0.02485));
		}
		
		void calc_temperature()
		{
			double p0 = 101325; // давление на уровне моря [Па]
			double T0 = Convert.ToDouble(temperature.Text)+273.15; // стандартная температура на уровне моря [К]
			double L = -0.0065; // среднее значение вертикальной компоненты градиента в тропосфере [К/м]
			double R = 8.31447; // универсальная газовая постоянная [Дж/моль*К]
			double M = 0.0289644; // молярная масса сухого воздуха [кг/моль]
			for (int h = 0; h < 20001; h++) 
			{
				double p = p0*Math.Pow((1+L*h/T0),-g*M/(R*L)); // давление воздуха на высоте h
				double T = T0 + L*h; //температура на высоте h над уровнем моря 
				densities[h]=p*M/(R*T); // плотность воздуха на высоте h
			}
		}
		
		void calculate()
		{
			airDensity.Text = densities[Convert.ToInt32(height.Text)].ToString(); // плотность воздуха из массива densities
			arhimedF.Text = (Convert.ToDouble(airDensity.Text)*Convert.ToDouble(volume.Text)*g).ToString(); // сила Архимеда F = RO_воздуха*g*V
			gasWeight.Text = (Convert.ToDouble(gasDensity.Text)*Convert.ToDouble(volume.Text)).ToString(); // масса газа m=Ro_газа*Vшара
			gasP.Text = (Convert.ToDouble(gasWeight.Text)*g).ToString(); // вес газа P = m_газа * g
			baloonP.Text = (g*(Convert.ToDouble(weight.Text)+Convert.ToDouble(gasWeight.Text))).ToString(); // вес шара P=g*(m_груза+m_шара)	
			upF.Text = (Convert.ToDouble(arhimedF.Text)-Convert.ToDouble(baloonP.Text)).ToString(); // Подъемная сила Fup = F_архимеда - P_аэростата
			
			draw(Convert.ToInt32(height.Text));
			
			if ( Convert.ToDouble(upF.Text) > 0) 
			{
				height.Text = (Convert.ToInt32(height.Text)+20).ToString();
				if (k!=0) 
				{ 
					upF.Text="0"; 
					arhimedF.Text=baloonP.Text;
					stop = true; Start.PerformClick(); 
				}
				if(!stop)
				{
					if (height.Text != 20000.ToString()) tmr.Start();
					else Start.PerformClick();
				}
			}
			else 
			if ( Convert.ToDouble(upF.Text) < 0 && Convert.ToInt32(height.Text)!=0 )
			{
				k++; tmr.Stop();
				height.Text = (Convert.ToInt32(height.Text)-20).ToString();
				tmr.Start();
			} else Start.PerformClick();
		}
		
		void StartClick(object sender, EventArgs e)
		{
			tmr.Stop();
			if (Start.Text=="Старт")
			{		
 				stop = false; k = 0;				
				gasDensity.ReadOnly = true;
				weight.ReadOnly = true;
				volume.ReadOnly = true;
				temperature.ReadOnly = true;
				Start.Text = "Стоп";
				calc_temperature();
				calculate();
			}
			else
			{				
				gasDensity.ReadOnly = false;
				weight.ReadOnly = false;
				volume.ReadOnly = false;
				temperature.ReadOnly = false;
				Start.Text = "Старт";
			}
		}
		
		void TmrTick(object sender, EventArgs e)
		{
			calculate();
		}
	}
}