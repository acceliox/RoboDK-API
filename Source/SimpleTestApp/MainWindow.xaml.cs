using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using Microsoft.Win32;
using RoboDk.API;
using RoboDk.API.Model;

namespace SimpleTestApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IRoboDK _roboDk;
        private string _localFilePath;

        public MainWindow()
        {
            InitializeComponent();

            _localFilePath = "";
            _roboDk = new RoboDK
            {
                RoboDKServerPort = 20500
            };
            _roboDk.Connect();
        }

        private void LoadRemoteFile(object sender, RoutedEventArgs routedEventArgs)
        {
            var fileDialog = new OpenFileDialog
            {
                Filter = ".rdk files|*.rdk"
            };

            if (fileDialog.ShowDialog() == true)
            {
                _localFilePath = fileDialog.FileName;
                LoadFileRemote();
            }
        }

        private void LoadFileRemote()
        {
            _roboDk = _roboDk.FileSetBuffered(_localFilePath);

            var robot = GetRobot();
            robot.JointLimits(out double[] min, out double[] max);
        }

        private IItem? GetRobot()
        {
            return _roboDk
                .GetItemList(ItemType.Robot)
                .SingleOrDefault(r =>
                {
                    r.JointLimits(out double[] l, out _);
                    return l.Length > 1;
                });
        }
    }
}