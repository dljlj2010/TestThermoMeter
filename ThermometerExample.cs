using System;
using System.Windows.Forms;
/// <summary>  
/// Thermometer控件的范例，介绍如何对它们的属性进行修改
/// 作者：简仪科技 
/// 日期：2016-12-14  
///  
/// 整体属性修改请详见参考手册
///BackColor	            配置表盘背景颜色
///BorderWidth              配置表盘边框厚度
///Glossiness               反光镜效果调试比例
///Max                      表盘最大值
///Min                      表盘最小值
///DescriptionText          表盘描述说明
///UnitText                 表盘单位描述
///NumberOfDivisions        表盘分隔个数，数值范围
///NumberOfSubDivisions     表盘子分隔个数，数值范围
///Value                    表盘所显示的当前值
/// </summary>  
namespace ThermometerExample
{
    public partial class ThermometerExample : Form
    {
        #region Private Fields
        #endregion   //Private Fields


        #region Constructor
        public ThermometerExample()
        {
            InitializeComponent();


        }

        #endregion  // Constructor


        #region Event Handler

        private void trackBarCurrentValue_Scroll(object sender, EventArgs e)
        {
            thermometer1.Value = trackBarCurrentValue.Value;
            thermometer2.Value = trackBarCurrentValue.Value;
            thermometer3.Value = trackBarCurrentValue.Value;
        }

        private void numericUpDownMin_ValueChanged(object sender, EventArgs e)
        {
            thermometer1.Min = (int)numericUpDownMin.Value;
        }

        private void numericUpDownDevision_ValueChanged(object sender, EventArgs e)
        {
            thermometer1.NumberOfDivisions = (int)numericUpDownDevision.Value;
        }

        private void buttonBackColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            thermometer1.ForeColor = colorDialog1.Color;
            buttonBackColor.BackColor = colorDialog1.Color;
        }

        private void numericUpDownMax_ValueChanged(object sender, EventArgs e)
        {
            thermometer1.Max =(int)numericUpDownMax.Value;
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            thermometer1.TextStyle = (TickStyle)Enum.Parse(typeof(TickStyle), listBox1.SelectedItem.ToString());
        }
    }

    #endregion // Event Handler

    #region Methods
    #endregion // Methods

}
