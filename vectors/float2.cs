namespace Michaudel.Mathematics
{
    public struct float2
    {
        public float X;
        public float Y;

        #region Constructors
        
        // Classic constructor
        public float2 (float x, float y)
        {
            X = x;
            Y = y;
        }
        
        // Ints constructor
        public float2 (int x, int y)
        {
            X = x;
            Y = y;
        }
        
        // Copy constructor
        public float2 (float2 toCopy)
        {
            X = toCopy.X;
            Y = toCopy.Y;
        }
        
        #endregion
        
        #region Operator
        
        // Positive alone
        public static float2 operator + (float2 vector) => vector;
        // Negative alone
        public static float2 operator - (float2 vector) => vector * -1;
        
        // Addition
        public static float2 operator + (float2 a, float2 b) => new (a.X + b.X, a.Y + b.Y);
        // Subtraction
        public static float2 operator - (float2 a, float2 b) => new (a.X - b.X, a.Y - b.Y);
        
        // Scalar
        public static float2 operator * (float2 a, float scalar) => new (a.X * scalar, a.Y * scalar);
        // Multiplication
        public static float2 operator * (float2 a, float2 b) => new (a.X * b.X, a.Y * b.Y);
        // Scalar division
        public static float2 operator / (float2 a, float scalar) => new (a.X / scalar, a.Y / scalar);
        // Division
        public static float2 operator / (float2 a, float2 b) => new (a.X / b.X, a.Y / b.Y);

        #endregion

        /// <summary>
        /// Dot product with another Vector
        /// </summary>
        /// <param name="b">The other Vector</param>
        public float Dot (float2 b)
        {
            return X * b.X + Y * b.Y;
        }
        
        /// <summary>
        /// Dot product between 2 Vectors
        /// </summary>
        /// <param name="a">The first Vector</param>
        /// <param name="b">The second Vector</param>
        public static float Dot (float2 a, float2 b)
        {
            return a.X * b.X + a.Y * b.Y;
        }
        
        /// <summary>
        /// Cross product with another Vector
        /// </summary>
        /// <param name="b">The other Vector</param>
        public float Cross (float2 b)
        {
            return X * b.Y - Y * b.X;
        }
        
        /// <summary>
        /// Cross product between 2 Vectors
        /// </summary>
        /// <param name="a">The first Vector</param>
        /// <param name="b">The second Vector</param>
        public static float Cross (float2 a, float2 b)
        {
            return a.X * b.Y - a.Y * b.X;
        }

        /// <summary>
        /// Vector Length, simple Pythagoras theorem
        /// </summary>
        public float Magnitude => (float)System.Math.Sqrt(X * X + Y * Y);

        /// <summary>
        /// Return a normalized version of this Vector, without altering the original one
        /// </summary>
        public float2 normalized 
        {
            get
            {
                // get the magnitude
                float mag = Magnitude;
                // get a copy of this vector
                float2 vec = new (this);

                // normalize it
                vec.X /= mag;
                vec.Y /= mag;

                // return it
                return vec;
            }
            // we could also do a set here, but tbh its quite useless
        }

        /// <summary>
        /// Normalize this Vector, making its length equal to 1
        /// </summary>
        /// <returns>This Vector, once normalized</returns>
        public float2 Normalize ()
        {
            // get the magnitude
            float mag = Magnitude;
            
            // normalize it
            X /= mag;
            Y /= mag;
            
            // return it
            return this;
        }
    }
}