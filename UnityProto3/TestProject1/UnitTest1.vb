Imports System.Text

<TestClass()>
Public Class UnitTest1

    <TestMethod()>
    Public Sub TestMethod1()

            int expected = 1;
            int result =1;
            assert.areequal(expected, result);

    End Sub

End Class
