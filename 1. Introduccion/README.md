# Etapa 1 - Introduccion a C#

## Actividad - Caja de banco
A continuación se describe la actividad que se necesita llevar a cabo

## Objetivo
Realizar un programa que simule el comportamiento de un cajero automatico de un banco, a partir de un conjunto de cantidades de dinero que el usuario ingrese, el programa deberá implementar una consola con la cantidad minima de billetes y monedas que se deben entregar para esas cantidades 

## Instrucciones
Se debe implementar un menú que permita escoger al usuario entre 2 opciones:
<ol>
    <li>Ingresar la cantidad de retiros hechos por los usuarios</li>
    <li>Revisar la cantidad entregada de billetes y monedas</li>  
</ol>

<br>

> Si se selecciona la primera opción, el programa deberá preguntar al usuario sobre la cantidad de retiros esto debe ser solo enteros positivos con un valor máximo de 10 y posteriormente el usuario ingresará la cantidad de dinero (sólo enteros positivos, con un valor máximo de 50,000) de cada retiro. Al terminar de ingresar las cantidades, el programa mostrará nuevamente el menú.

> Si el usuario selecciona la segunda opción el programa imprimirá en consola la cantidad mínima de billetes y monedas que se entregaron para cada cantidad. Se mostrará el
mensaje “Presiona ‘enter’ para continuar …” y cuando el usuario presione la tecla enter, el programa volverá al menú.

<ul type="disc">
    <li>La cantidad de dinero que se ingresará para cada retiro deberá ser un valor entero, mayor a 0 y menor o igual a 50,000</li>
    <li>Los billetes que se considerarán en el programa serán de $20, $50, $100, $200 y $500</li>
    <li>Las monedas que se considerarán en el programa serán de $1,  $5 y $10 pesos.</li>
    <li>Se deberá imprimir la cantidad minima de billetes para cada retiro, por ejemplo la cantidad de $2,346 pesos necesita:</li>
    <ul>
        <li>4 billetes de $500 + 1 billete de $200 + 1 billete de $100 + 2 billetes de $20, en total son 8 billetes que conforman hasta el momento $2,340 pesos</li>
        <li>Así mismo se debe entregar una moneda de $5 pesos y otra moneda de $1, lo cual forma $6, es decir que en total estaríamos dando $2,346</li>
    </ul>
    <li> Deberás utilizar un arreglo que almacene los retiros del usuario. </li>
    <li> Considera bucles que aumenten contadores de billetes y monedas en cada iteración y que, además, también disminuyan la cantidad del retiro en cada iteración </li>
</ul>