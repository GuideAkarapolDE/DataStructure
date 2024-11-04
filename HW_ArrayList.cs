using System;
using System.Windows.Forms;
using Lists;

namespace HW_ArrayList
{
    public partial class ArrayForm : Form
    {
        public ArrayForm()
        {
            InitializeComponent();
        }

        List list = new ArrayList(5);

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string name = FillBox.Text;
            if (!string.IsNullOrEmpty(name)) // ตรวจสอบว่าชื่อไม่ว่างเปล่า
            {
                list.add(name);
                FillBox.Clear();
                MessageBox.Show($"คุณได้เพิ่ม {name} เข้ามาในรายการแล้ว");
            }
            else
            {
                FillBox.Clear();
                MessageBox.Show("โปรดใส่ข้อความ");
            }
            ListLabel.Text = list.size().ToString();
        }
        private void FindBtn_Click(object sender, EventArgs e)
        {
            string FindName = FillBox.Text;
            if (list.contains(FindName))
            {
                MessageBox.Show($"พบชื่อ {FindName} ในรายการ");
            }
            else
            {
                MessageBox.Show($"ไม่พบชื่อ {FindName} ในรายการ");
            }
            FillBox.Clear();
        }
        private void DelBtn_Click(object sender, EventArgs e)
        {
            string DelName = FillBox.Text;
            if (list.contains(DelName))
            {
                list.remove(DelName);
                MessageBox.Show($"ลบชื่อ {DelName} สำเร็จ");
            }
            else
            {
                MessageBox.Show($"ไม่พบชื่อ {DelName} ในรายการ");
            }
            FillBox.Clear();
            ListLabel.Text = list.size().ToString();
        }
        private void FindIndexBtn_Click(object sender, EventArgs e)
        {
            int MyIndex;
            IndexEditBox.Clear();

            if (int.TryParse(FindIndexBox.Text, out MyIndex))
            {

                MyIndex--; // ทำให้ index เริ่มจาก 1 (มาจาก 1-1 = 0 ซึ่ง 0 จะเท่ากับลำดับที่ 0 ใน index)

                if (MyIndex >= 0 && MyIndex < list.size())
                {
                    IndexEditBox.Text = list.get(MyIndex).ToString();
                    OnIndexEdit();
                } else
                {
                    MessageBox.Show($"ไม่พบรายชื่อลำดับที่ {FindIndexBox.Text} ในรายการ");
                    OffIndexEdit();
                }
            } else
            {
                MessageBox.Show($"โปรดใส่ลำดับของรายชื่อให้ถูกต้อง");
                OffIndexEdit();
            }
            //FindIndexBox.Clear();
        }
        private void IndexEditBtn_Click(object sender, EventArgs e)
        {
            int index = int.Parse(FindIndexBox.Text) - 1; // ได้ index ที่ต้องการแก้ไขมาแล้ว
            string UpdateData = IndexEditBox.Text;

            
            list.set(index, UpdateData); // แก้ไขข้อมูลที่ตำแหน่ง index
            MessageBox.Show($"แก้ไขข้อมูลในลำดับที่ {index + 1} เป็น {UpdateData} สำเร็จ");

            IndexEditBox.Clear();
            FindIndexBox.Clear();
        }
        private void ListShowBtn_Click(object sender, EventArgs e)
        {
            ListView.Items.Clear();
            
            // วนลูปข้อมูลใน ArrayList และเพิ่มลงใน ListBox
            for (int i = 0; i < list.size(); i++)
            {
                ListView.Items.Add($"{i + 1}. " + list.get(i));
            }
        }

        private void OnIndexEdit()
        {
            IndexEditBox.Enabled = true;
            IndexEditBtn.Enabled = true;
        } // เปิด Box และ Button ของ IndexEdit
        private void OffIndexEdit()
        {
            IndexEditBox.Enabled = false;
            IndexEditBtn.Enabled = false;
        } // ปิด Box และ Button ของ IndexEdit
    }
}
