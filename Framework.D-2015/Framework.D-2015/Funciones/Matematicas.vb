Namespace Funciones

    Public Class Matematicas

        ''' <summary>
        ''' Ingreso un numero y lo redondea la cantidad de decimales deseada.
        ''' </summary>
        ''' <param name="unNumero">Ingrese cualquier numero.</param>
        ''' <param name="cantidadDecimales">Ingrese la cantidad de decimales.</param>
        ''' <returns></returns>
        ''' <remarks></remarks>

        Public Shared Function Redondear(unNumero As Decimal, cantidadDecimales As Integer) As Decimal

            'wrapper
            Return Math.Round(unNumero, cantidadDecimales)


        End Function

        ''' <summary>
        ''' Devuelve un numero entro los valores indicados.
        ''' </summary>
        ''' <param name="desde"></param>
        ''' <param name="hasta"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>

        Public Shared Function ObtenerNumeroAleatorio(desde As Integer, hasta As Integer) As Integer

            Dim rnd As New Random

            Dim resultado As Integer = rnd.Next(desde, hasta + 1)

            Return resultado

        End Function


        ''' <summary>
        ''' Obtener un Interes del 21%
        ''' </summary>
        ''' <param name="Valor"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function ObetenerInteresIVA(Valor As Double) As Double
            Dim valorFinal = (Valor * 0.21) + Valor

            Return valorFinal

        End Function
        ''' <summary>
        ''' Suma de 2 numeros
        ''' </summary>
        ''' <param name="Numero1"></param>
        ''' <param name="Numero2"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function Suma(Numero1 As Double, Numero2 As Double) As Double
            Dim sumafinal = Numero1 + Numero2
            Return sumafinal

        End Function





        ''' <summary>
        ''' Descuento
        ''' </summary>
        ''' <param name="ImporteNeto">Ingrese Importe</param>
        ''' <param name="PorcentajeDescontar">Ingrese % de descuento</param>
        ''' <returns>Devuelve importe con descuento</returns>
        ''' <remarks></remarks>

        Public Shared Function AplicarDescuento(ImporteNeto As Double, PorcentajeDescontar As Double) As Double
            Dim Resultado As Double

            Resultado = ImporteNeto - (ImporteNeto * PorcentajeDescontar / 100)

            Return Resultado
        End Function


        ''' <summary>
        ''' Recargo
        ''' </summary>
        ''' <param name="ImporteNeto">Ingrese Importe</param>
        ''' <param name="PorcentajeRecargo">Ingrese % recargo</param>
        ''' <returns>Devuelve importe con recargo</returns>
        ''' <remarks></remarks>
        Public Shared Function AplicarRecargo(ImporteNeto As Double, PorcentajeRecargo As Double) As Double
            Dim Resultado As Double

            Resultado = ImporteNeto + (ImporteNeto * PorcentajeRecargo / 100)

            Return Resultado
        End Function

    End Class





    '1) Metodo AplicarDescuento(ImporteNeto, PorcentajeDescontar) devuelve el importe aplicando el descuento del porcentaje ingresado. (ejemplo: AplicarDescuento(100, 10) = 90)
    '2) Metodo AplicarRecargo(ImporteNeto, PorcentajeRecargo) devuelve el importe aplicando el recargo ingresado. (Ejemplo: AplicarRecargo(100, 10) = 110
    '3) Metodo redondear. Ingreso un numero y deve tener hasta 2 decimales.







End Namespace

