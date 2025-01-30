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
    public static double AreaOfCircle(double radius) {
        return double.Pow(radius, 2.0) * double.Pi;
    }
    public static double AreaOfTriangle(double triangleBase, double triangleHeight ) {
        throw new NotImplementedException();
    }
    

}
