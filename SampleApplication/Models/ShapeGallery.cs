using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication.Models
{
    internal class ShapeGallery
    {
        private static ShapeGallery shapeGallery;
        private List<Shape> shapes;

        public List<Shape> Shapes { get { return shapes; } }

        private ShapeGallery()
        {
            shapes = new List<Shape>();
        }

        public static ShapeGallery GetShapeGallery()
        {
            if(shapeGallery == null)
            {
               shapeGallery = new ShapeGallery();
            }

            return shapeGallery;
        }

        public void AddShape(Shape shape)
        {
            shapes.Add(shape);
        }
    }
}
