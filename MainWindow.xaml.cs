using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Media3D;

namespace _3dWPFTutorial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            BuildSolid();
        }

        private GeometryModel3D geoModel;
        private bool mDown;
        private Point lastPosition;

        public void BuildSolid()
        {
            MeshGeometry3D mesh = new MeshGeometry3D();

            //CUBE 3D
            
            //Front Face Points
            mesh.Positions.Add(new Point3D(2, 2, 4));
            mesh.Positions.Add(new Point3D(3, 2, 4));
            mesh.Positions.Add(new Point3D(4, 2, 4));
            mesh.Positions.Add(new Point3D(4, 3, 4));
            mesh.Positions.Add(new Point3D(4, 4, 4));
            mesh.Positions.Add(new Point3D(3, 4, 4));
            mesh.Positions.Add(new Point3D(2, 4, 4));
            mesh.Positions.Add(new Point3D(2, 3, 4));
            mesh.Positions.Add(new Point3D(3, 3, 4));

            //Ghost frame
            mesh.Positions.Add(new Point3D(2, 2, 3));
            mesh.Positions.Add(new Point3D(3, 2, 3));
            mesh.Positions.Add(new Point3D(4, 2, 3));
            mesh.Positions.Add(new Point3D(4, 3, 3));
            mesh.Positions.Add(new Point3D(4, 4, 3));
            mesh.Positions.Add(new Point3D(3, 4, 3));
            mesh.Positions.Add(new Point3D(2, 4, 3));
            mesh.Positions.Add(new Point3D(2, 3, 3));

            //Back Face Points
            mesh.Positions.Add(new Point3D(2, 2, 2));
            mesh.Positions.Add(new Point3D(3, 2, 2));
            mesh.Positions.Add(new Point3D(4, 2, 2));
            mesh.Positions.Add(new Point3D(4, 3, 2));
            mesh.Positions.Add(new Point3D(4, 4, 2));
            mesh.Positions.Add(new Point3D(3, 4, 2));
            mesh.Positions.Add(new Point3D(2, 4, 2));
            mesh.Positions.Add(new Point3D(2, 3, 2));
            mesh.Positions.Add(new Point3D(3, 3, 2));
                        

            // Front Face Triangles
            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(8);
            mesh.TriangleIndices.Add(8);
            mesh.TriangleIndices.Add(7);
            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(3);
            mesh.TriangleIndices.Add(3);
            mesh.TriangleIndices.Add(8);
            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(8);
            mesh.TriangleIndices.Add(3);
            mesh.TriangleIndices.Add(4);
            mesh.TriangleIndices.Add(4);
            mesh.TriangleIndices.Add(5);
            mesh.TriangleIndices.Add(8);
            mesh.TriangleIndices.Add(5);
            mesh.TriangleIndices.Add(6);
            mesh.TriangleIndices.Add(7);
            mesh.TriangleIndices.Add(7);
            mesh.TriangleIndices.Add(8);
            mesh.TriangleIndices.Add(5);

            //17,18,25,25,24,17,18,19,20,20,25,18,25,20,21,21,22,25,22,23,24,24,25,22
            // Back Face Triangles
            mesh.TriangleIndices.Add(22);
            mesh.TriangleIndices.Add(25);
            mesh.TriangleIndices.Add(24);
            mesh.TriangleIndices.Add(24);
            mesh.TriangleIndices.Add(23);
            mesh.TriangleIndices.Add(22);
            mesh.TriangleIndices.Add(25);
            mesh.TriangleIndices.Add(22);
            mesh.TriangleIndices.Add(21);
            mesh.TriangleIndices.Add(21);
            mesh.TriangleIndices.Add(20);
            mesh.TriangleIndices.Add(25);
            mesh.TriangleIndices.Add(18);
            mesh.TriangleIndices.Add(25);
            mesh.TriangleIndices.Add(20);
            mesh.TriangleIndices.Add(20);
            mesh.TriangleIndices.Add(19);
            mesh.TriangleIndices.Add(18);
            mesh.TriangleIndices.Add(17);
            mesh.TriangleIndices.Add(24);
            mesh.TriangleIndices.Add(25);
            mesh.TriangleIndices.Add(25);
            mesh.TriangleIndices.Add(18);
            mesh.TriangleIndices.Add(17);

            // Right Face Triangles
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(11);
            mesh.TriangleIndices.Add(12);
            mesh.TriangleIndices.Add(12);
            mesh.TriangleIndices.Add(3);
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(11);
            mesh.TriangleIndices.Add(19);
            mesh.TriangleIndices.Add(20);
            mesh.TriangleIndices.Add(20);
            mesh.TriangleIndices.Add(12);
            mesh.TriangleIndices.Add(11);
            mesh.TriangleIndices.Add(12);
            mesh.TriangleIndices.Add(20);
            mesh.TriangleIndices.Add(21);
            mesh.TriangleIndices.Add(21);
            mesh.TriangleIndices.Add(13);
            mesh.TriangleIndices.Add(12);
            mesh.TriangleIndices.Add(13);
            mesh.TriangleIndices.Add(4);
            mesh.TriangleIndices.Add(3);
            mesh.TriangleIndices.Add(3);
            mesh.TriangleIndices.Add(12);
            mesh.TriangleIndices.Add(13);

            // Left Face Triangles
            mesh.TriangleIndices.Add(15);
            mesh.TriangleIndices.Add(16);
            mesh.TriangleIndices.Add(7);
            mesh.TriangleIndices.Add(7);
            mesh.TriangleIndices.Add(6);
            mesh.TriangleIndices.Add(15);
            mesh.TriangleIndices.Add(16);
            mesh.TriangleIndices.Add(15);
            mesh.TriangleIndices.Add(23);
            mesh.TriangleIndices.Add(23);
            mesh.TriangleIndices.Add(24);
            mesh.TriangleIndices.Add(16);
            mesh.TriangleIndices.Add(9);
            mesh.TriangleIndices.Add(16);
            mesh.TriangleIndices.Add(24);
            mesh.TriangleIndices.Add(24);
            mesh.TriangleIndices.Add(17);
            mesh.TriangleIndices.Add(9);
            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(7);
            mesh.TriangleIndices.Add(16);
            mesh.TriangleIndices.Add(16);
            mesh.TriangleIndices.Add(9);
            mesh.TriangleIndices.Add(0);

            // Bottom Face Triangles
            mesh.TriangleIndices.Add(17);
            mesh.TriangleIndices.Add(18);
            mesh.TriangleIndices.Add(10);
            mesh.TriangleIndices.Add(10);
            mesh.TriangleIndices.Add(9);
            mesh.TriangleIndices.Add(17);
            mesh.TriangleIndices.Add(18);
            mesh.TriangleIndices.Add(19);
            mesh.TriangleIndices.Add(11);
            mesh.TriangleIndices.Add(11);
            mesh.TriangleIndices.Add(10);
            mesh.TriangleIndices.Add(18);
            mesh.TriangleIndices.Add(10);
            mesh.TriangleIndices.Add(11);
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(10);
            mesh.TriangleIndices.Add(9);
            mesh.TriangleIndices.Add(10);
            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(9);

            // Left Face Triangles
            mesh.TriangleIndices.Add(6);
            mesh.TriangleIndices.Add(5);
            mesh.TriangleIndices.Add(14);
            mesh.TriangleIndices.Add(14);
            mesh.TriangleIndices.Add(15);
            mesh.TriangleIndices.Add(6);
            mesh.TriangleIndices.Add(5);
            mesh.TriangleIndices.Add(4);
            mesh.TriangleIndices.Add(13);
            mesh.TriangleIndices.Add(13);
            mesh.TriangleIndices.Add(14);
            mesh.TriangleIndices.Add(5);
            mesh.TriangleIndices.Add(14);
            mesh.TriangleIndices.Add(13);
            mesh.TriangleIndices.Add(21);
            mesh.TriangleIndices.Add(21);
            mesh.TriangleIndices.Add(22);
            mesh.TriangleIndices.Add(14);
            mesh.TriangleIndices.Add(15);
            mesh.TriangleIndices.Add(14);
            mesh.TriangleIndices.Add(22);
            mesh.TriangleIndices.Add(22);
            mesh.TriangleIndices.Add(23);
            mesh.TriangleIndices.Add(15);

            geoModel = new GeometryModel3D(mesh, new DiffuseMaterial(Brushes.Gray));
            geoModel.Transform = new Transform3DGroup();
            lightGroup.Children.Add(geoModel);
        }

        private void Grid_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            orthoCam.Position = new Point3D(orthoCam.Position.X,
                orthoCam.Position.Y,
                orthoCam.Position.Z - e.Delta / 1000D);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            orthoCam.Position = new Point3D(0, 0, 5);
            geoModel.Transform = new Transform3DGroup();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton != MouseButtonState.Pressed) return;
            mDown = true;
            Point pos = Mouse.GetPosition(mainViewport);
            lastPosition = new Point(pos.X - mainViewport.ActualWidth / 2, mainViewport.ActualHeight / 2 - pos.Y);
        }

        private void Grid_MouseUp(object sender, MouseButtonEventArgs e)
        {
            mDown = false;
        }

        private void Grid_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mDown) return;
            Point pos = Mouse.GetPosition(mainViewport);
            Point actualPos = new Point(pos.X - mainViewport.ActualWidth / 2, mainViewport.ActualHeight / 2 - pos.Y);
            double dx = actualPos.X - lastPosition.X;
            double dy = actualPos.Y - lastPosition.Y;
            double mouseAngle = 0;

            if (dx != 0 && dy != 0)
            {
                mouseAngle = Math.Asin(Math.Abs(dy) / Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dy, 2)));
                if (dx < 0 && dy > 0)
                    mouseAngle += Math.PI / 2;
                else if (dx < 0 && dy < 0)
                    mouseAngle += Math.PI;
                else if (dx > 0 && dy < 0)
                    mouseAngle += Math.PI * 1.5;
            }
            else if (dx == 0 && dy != 0)
            {
                mouseAngle = Math.Sign(dy) > 0 ? Math.PI / 2 : Math.PI * 1.5;
            }
            else if (dx != 0 && dy == 0)
            {
                mouseAngle = Math.Sign(dx) > 0 ? 0 : Math.PI;
            }

            double axisAngle = mouseAngle + Math.PI / 2;

            Vector3D axis = new Vector3D(Math.Cos(axisAngle) * 4, Math.Sin(axisAngle) * 4, 0);
            double rotation = 0.01 * Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dy, 2));

            Transform3DGroup group = geoModel.Transform as Transform3DGroup;
            QuaternionRotation3D rot = new QuaternionRotation3D(new Quaternion(axis, rotation * 180 / Math.PI));
            group.Children.Add(new RotateTransform3D(rot));
            lastPosition = actualPos;
        }
    }
}
