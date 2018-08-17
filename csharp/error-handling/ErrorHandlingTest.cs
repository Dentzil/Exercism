using System;
using Xunit;

public class ErrorHandlingTest
{
    [Fact]
    public void ThrowException()
    {
        Assert.Throws<Exception>(() => ErrorHandling.HandleErrorByThrowingException());
    }

    [Fact]
    public void ReturnNullableType()
    {
        var successfulResult = ErrorHandling.HandleErrorByReturningNullableType("1");
        Assert.Equal(1, successfulResult);

        var failureResult = ErrorHandling.HandleErrorByReturningNullableType("a");
        Assert.Null(failureResult);
    }

    [Fact]
    public void ReturnWithOutParameter()
    {
        int result;
        var successfulResult = ErrorHandling.HandleErrorWithOutParam("1", out result);
        Assert.True(successfulResult);
        Assert.Equal(1, result);
        
        var failureResult = ErrorHandling.HandleErrorWithOutParam("a", out result);
        Assert.False(failureResult);
    }

    private class DisposableResource : IDisposable
    {
        public bool IsDisposed { get; private set; }

        public void Dispose()
        {
            IsDisposed = true;
        }
    }

    [Fact]
    public void DisposableObjectsAreDisposedWhenThrowingAnException()
    {
        var disposableResource = new DisposableResource();

        Assert.Throws<Exception>(() => ErrorHandling.DisposableResourcesAreDisposedWhenExceptionIsThrown(disposableResource));
        Assert.True(disposableResource.IsDisposed);
    }
}
