using System.Reflection;
using System.Xml;

namespace MainabaCopyPaster
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		/// <summary>
		/// �ǂݍ��ރ{�^���N���b�N
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button1_Click(object sender, EventArgs e)
		{
			var appDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
			var xmlFilePath = Path.Combine(appDirectory, "..", "..", "..", "setting.xml");

			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.Load(xmlFilePath);

			var ankenName = textBox1.Text;
			var basePath = "C:\\vuptemp\\" + ankenName + "\\";

			var currentFolder = (comboBox1.Text == "�e�X�g") ? "current_test" : "current_honban";
			var updateFolder = (comboBox1.Text == "�e�X�g") ? "�X�V�p�t�@�C��-Test" : "�X�V�p�t�@�C��-Honban";

			var currentPath = Path.Combine(basePath, currentFolder, comboBox2.Text);
			var updatePath = Path.Combine(basePath, updateFolder, comboBox2.Text);

			new Form2(currentPath, updatePath, Path.Combine(basePath, updateFolder), xmlDocument).ShowDialog();

			// Settings.xml�Ɋe�����̒l��ۑ�
			XmlNode currentPathhNode = xmlDocument.SelectSingleNode("/Settings/Shortcut/CurrentRootPath");
			XmlNode updatePathNode = xmlDocument.SelectSingleNode("/Settings/Shortcut/UpdateRootPath");
			if (currentPathhNode != null)
			{
				currentPathhNode.InnerText = currentPath;
			}
			if (updatePathNode != null)
			{
				updatePathNode.InnerText = updatePath;
			}
			xmlDocument.Save(xmlFilePath);
		}
	}
}
