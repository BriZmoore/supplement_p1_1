namespace supplement_p1_1;

public class supplement_p1_1
{
    /// <summary>
    /// Returns the area of a rectangle. If the lenght is equal to width, 
    /// calculation is done as length * length instead.
    /// </summary>
    /// <param name="length">Lenght of the Rectangle.</param>
    /// <param name="width">Width of the rectangle.</param>
    /// <returns>Area of the rectangle.</returns>
    public static double AreaOfRectangle(double length, double width) {
        if (length == width){
            return length * length; //or double.Pow(length, 2.0)
        } else{
            return length * width;
        }
        

    }
    /// <summary>
    /// Returns the area of a circle. 
    /// </summary>
    /// <param name="radius">Radius of a circle.</param>
    /// <returns>The area of a circle with a given radius.</returns>
    public static double AreaOfCircle(double radius) {
        return double.Pow(radius, 2.0) * double.Pi;
    }
    public static double AreaOfTriangle(double triangleBase, double triangleHeight ) {
        throw new NotImplementedException();
    }
    

}
