using System;
using System.Windows.Forms;
using Collections;
using SET;

namespace HW_LinkedCollection
{
    public partial class HW_LinkedCollection : Form
    {
        public HW_LinkedCollection()
        {
            InitializeComponent();
        }

        Collection array = new LinkedSet();


        private void AddBtn_Click(object sender, EventArgs e)
        {
            string name = AddBox.Text;
            if (name != null && name != "") // ตรวจสอบว่าชื่อไม่ว่างเปล่า
            {
                array.add(name);
                AddBox.Clear();
                MessageBox.Show($"คุณได้เพิ่ม {name} เข้ามาในรายการแล้ว");
            } else
            {
                AddBox.Clear();
                MessageBox.Show("โปรดใส่ข้อความ");
            }
            ListLabel.Text = array.size().ToString();
        }

        private void FindBtn_Click(object sender, EventArgs e)
        {
            string FindName = FindBox.Text;
            if (array.contains(FindName))
            {
                MessageBox.Show($"พบชื่อ {FindName} ในรายการ");
            }
            else
            {
                MessageBox.Show($"ไม่พบชื่อ {FindName} ในรายการ");
            }
            FindBox.Clear();
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            string DelName = DelBox.Text;
            if (array.contains(DelName))
            {
                array.remove(DelName);
                MessageBox.Show($"ลบชื่อ {DelName} สำเร็จ");
            }
            else
            {
                MessageBox.Show($"ไม่พบชื่อ {DelName} ในรายการ");
            }
            DelBox.Clear();
            ListLabel.Text = array.size().ToString();
        }
    }
}
