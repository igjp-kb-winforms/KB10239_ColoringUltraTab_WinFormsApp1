using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win;

namespace KB10239_ColoringUltraTab_WinFormsApp1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        ultraTabControl1.UseOsThemes = DefaultableBoolean.False;

        // �R���e���c�̈�̔w�i�F�̊���l�pAppearance�I�u�W�F�N�g
        if (!ultraTabControl1.Appearances.Exists("Default"))
        {
            Infragistics.Win.Appearance defaultAppearance = ultraTabControl1.Appearances.Add("Default");
            defaultAppearance.BackColor = SystemColors.Control;
        }

        // �����D�F��Appearance�I�u�W�F�N�g
        if (!ultraTabControl1.Appearances.Exists("LightGray"))
        {
            Infragistics.Win.Appearance lightGrayAppearance = ultraTabControl1.Appearances.Add("LightGray");
            lightGrayAppearance.ForeColor = Color.Black;
            lightGrayAppearance.BackColor = Color.LightGray;
        }

        // ����Appearance�I�u�W�F�N�g
        if (!ultraTabControl1.Appearances.Exists("Black"))
        {
            Infragistics.Win.Appearance blackAppearance = ultraTabControl1.Appearances.Add("Black");
            blackAppearance.ForeColor = Color.White;
            blackAppearance.BackColor = Color.Black;
        }

        // �����s���N��Appearance�I�u�W�F�N�g
        if (!ultraTabControl1.Appearances.Exists("LightPink"))
        {
            Infragistics.Win.Appearance lightPinkAppearance = ultraTabControl1.Appearances.Add("LightPink");
            lightPinkAppearance.ForeColor = Color.Black;
            lightPinkAppearance.BackColor = Color.LightPink;
        }

        // �Ԃ�Appearance�I�u�W�F�N�g
        if (!ultraTabControl1.Appearances.Exists("Red"))
        {
            Infragistics.Win.Appearance redAppearance = ultraTabControl1.Appearances.Add("Red");
            redAppearance.ForeColor = Color.White;
            redAppearance.BackColor = Color.Red;
        }

        // Appearance�̐ݒ�
        ultraTabControl1.Tabs[0].Appearance = ultraTabControl1.Appearances["LightGray"]; // ���莞
        ultraTabControl1.Tabs[0].ActiveAppearance = ultraTabControl1.Appearances["Black"];   // �A�N�e�B�u��
        ultraTabControl1.Tabs[0].ClientAreaAppearance = ultraTabControl1.Appearances["Default"];    // �R���e���c�̈�̔w�i�F�̍Đݒ�

        ultraTabControl1.Tabs[1].Appearance = ultraTabControl1.Appearances["LightPink"];
        ultraTabControl1.Tabs[1].ActiveAppearance = ultraTabControl1.Appearances["Red"];
        ultraTabControl1.Tabs[1].ClientAreaAppearance = ultraTabControl1.Appearances["Default"];
    }
}
