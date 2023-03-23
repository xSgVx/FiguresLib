namespace ModelTests
{
    public class ModelTests
    {
        FigureAnalizer analizer;

        [SetUp]
        public void Setup()
        {
            analizer = new FigureAnalizer();
        }

        [Test]
        public void CreateNewInstanceOfCircleTest()
        {

            Circle circleInstance = new Circle(10);
            Figure figureInstance = new Circle(10);

            Assert.IsInstanceOf(typeof(Circle), figureInstance);
        }

        [Test]
        public void CreateNewInstanceOfTriangleTest()
        {
            Triangle triangleInstance = new Triangle(3,4,5);
            Figure figureInstance = new Triangle(3,4,5);

            Assert.IsInstanceOf(typeof(Triangle), figureInstance);
        }

        [Test]
        public void IsRightTriangleTest()
        {
            Triangle triangle = new Triangle(5, 4, 3);

            Assert.That(triangle.IsRight, Is.EqualTo(true));
        }

        [Test]
        public void IsNotRightTrianglTest()
        {
            Triangle triangle = new Triangle(4, 4, 6);

            Assert.That(triangle.IsRight, Is.EqualTo(false));
        }

        [Test]
        public void TriangleFromSidesEqualsToTriangleFromPointsTest()
        {
            Triangle sideTriangle = new Triangle(4, 3, 5);
            Triangle pointsTriangle = new Triangle(new Point(1,1), new Point(4, 1), new Point(1, 5));

            Assert.IsTrue(sideTriangle.FigureArea.Equals(pointsTriangle.FigureArea) &&
                          sideTriangle.FigurePerimeter.Equals(pointsTriangle.FigurePerimeter) &&
                          sideTriangle.IsRight.Equals(pointsTriangle.IsRight));
        }

        [Test]
        public void TriangleFromSidesNotEqualsToTriangleFromPointsTest()
        {
            Triangle sideTriangle = new Triangle(5, 6, 7);
            Triangle pointsTriangle = new Triangle(new Point(1, 1), new Point(4, 1), new Point(1, 5));

            Assert.IsFalse(sideTriangle.FigureArea.Equals(pointsTriangle.FigureArea) &&
                           sideTriangle.FigurePerimeter.Equals(pointsTriangle.FigurePerimeter) &&
                           sideTriangle.IsRight.Equals(pointsTriangle.IsRight));
        }

        [Test]
        public void AnalizeEqualityWithAnalizer()
        {
            Figure triangle = new Triangle(5, 6, 7);
            Figure circle = new Circle(5);

            Assert.That(analizer.EqualFigures(circle, triangle), Is.EqualTo(false));
        }
    }
}