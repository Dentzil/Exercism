namespace Exercism_error_handling
{
    using System;

    public class ErrorHandling
    {
        public static void DisposableResourcesAreDisposedWhenExceptionIsThrown(IDisposable obj)
        {
            obj.Dispose();

            throw new Exception();
        }

        public static int? HandleErrorByReturningNullableType(string input)
        {
            int result;

            return int.TryParse(input, out result) ? (int?)result : null;
        }

        public static void HandleErrorByThrowingException()
        {
            throw new Exception();
        }

        public static bool HandleErrorWithOutParam(string input, out int result)
        {
            return int.TryParse(input, out result);
        }
    }
}
