using System;
using System.Windows.Forms;

namespace Organizer.Forms
{
    public partial class Shedulescs : Form
    {
        public Shedulescs()=>
            InitializeComponent();
        

        private void UpdateViews()
        {
            DelSheduleText.Items.Clear();
            SheduleData.Rows.Clear();
           GetEvent events = new GetEvent();
            var shedules = events.Get();
            foreach (Event shedule in shedules)
            {
                SheduleData.Rows.Add(shedule.CODE,
                                   shedule.EventText,
                                          shedule.Date);
                DelSheduleText.Items.Add(shedule.EventText);
            }
        }

        private void Shedulescs_Load(object sender, EventArgs e)=>
            UpdateViews();
        

        private void DelButton_Click(object sender, EventArgs e)
        {
            if(DelSheduleText.Text!="" && DelSheduleText.Text!=null && DelSheduleText.Text.Length!=0)
            {
                DelEvent delEvent = new DelEvent();
                delEvent.Del(DelSheduleText.Text);
                UpdateViews();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (AddSheduleText.Text != "" && AddSheduleText.Text != null && AddSheduleText.Text.Length!=0)
            {
                AddEvent addEvent = new AddEvent();
                addEvent.Add(AddSheduleText.Text, AddSheduleDate.Value);
                UpdateViews();
            }
        }
    }
}
