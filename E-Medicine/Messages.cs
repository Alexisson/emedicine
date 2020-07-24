using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Medicine
{
    class Messages
    {
        public void WriteError()
        {
            MessageBox.Show("Запись не удалась", "Ошибка записи", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void WriteSuccess()
        {
            MessageBox.Show("Данные успешно добавлены!", "Успешная запись", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void DataError(string str)
        {
            MessageBox.Show(str, "Ошибка данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void DropSuccess()
        {
            MessageBox.Show("Данные успешно удалены!", "Успешное удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void DropError()
        {
            MessageBox.Show("Удаление не удалось", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
