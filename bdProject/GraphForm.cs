using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace bdProject
{
    public partial class GraphForm : Form
    {
        string[] words;
        Dictionary<string, int[]> wordsCoords = new Dictionary<string, int[]>();

        public GraphForm()
        {
            InitializeComponent();
        }

        public void drawGraph(string word, int[] coordsArr)
        {
            wordsCoords.Add(word, coordsArr);
            ZedGraphControl graphControl = new ZedGraphControl();
            graphControl.Size = new Size(665, 280);
            int y = panel1.Controls.Count * 283;
            graphControl.Location = new Point(3, y);
            graphControl.Anchor = AnchorStyles.Top & AnchorStyles.Left & AnchorStyles.Right;
            panel1.Controls.Add(graphControl);
            GraphPane pane = zedGraphControl1.GraphPane;
            pane.Title = "Распределение частот слова " + word;
            pane.XAxis.Title = "Предложения";
            pane.YAxis.Title = "Частота встречаемости слова";
            pane.CurveList.Clear();

            // Создадим список точек для кривой f1(x)
            PointPairList f_list = new PointPairList();

            //// Создадим список точек для кривой f2(x)
            //PointPairList f2_list = new PointPairList();

            int xmin = 0;
            int xmax = MainForm.sentCount;
            int step = 10;

            // !!!
            // Заполним массив точек для кривой f1(x)
            for (int i = xmin / step; i < step - 1; i++)
            {
                f_list.Add(i * (xmax / step), coordsArr[i]);
            }
            f_list.Add(xmax, coordsArr[step - 1]);

            //// !!!
            //// Заполним массив точек для кривой f2(x)
            //// Интервал и шаги по X могут не совпадать на разных кривых
            //for (double x = 0; x <= xmax; x += 0.5)
            //{
            //    f2_list.Add(x, f2(x));
            //}

            // !!!
            // Создадим кривую с названием "Sinc", 
            // которая будет рисоваться голубым цветом (Color.Blue),
            // Опорные точки выделяться не будут (SymbolType.None)
            LineItem f1_curve = pane.AddCurve(word, f_list, Color.Blue, SymbolType.Circle);

            //// !!!
            //// Создадим кривую с названием "Sin", 
            //// которая будет рисоваться красным цветом (Color.Red),
            //// Опорные точки будут выделяться плюсиками (SymbolType.Plus)
            //LineItem f2_curve = pane.AddCurve(word, f2_list, Color.Red, SymbolType.Plus);

            // Вызываем метод AxisChange (), чтобы обновить данные об осях. 
            // В противном случае на рисунке будет показана только часть графика, 
            // которая умещается в интервалы по осям, установленные по умолчанию
            zedGraphControl1.AxisChange();

            // Обновляем график
            zedGraphControl1.Invalidate();
        }

        private void ChangeSizeButton_Click(object sender, EventArgs e)
        {
            int beginSent = Convert.ToInt32(sentBeginTextBox.Text);
            int endSent = Convert.ToInt32(sentEndTextBox.Text);
        //    drawGraph(words[0], )
        }
    }
}
