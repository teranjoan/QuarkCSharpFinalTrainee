# Quark Academy

## _Teran Joan, examen final C#_

Esta es una aplicacion de Consola para Microsoft Windows.

## Ejecucion

Se debera buscar en el explorador de archivos, en la raiz del repositorio, la siguiente ruta:

```sh
TeranJoanQuarkExamenModuloCSharp/bin/Debug/netcoreapp3.1
```

Ahi podremos ver el archivo:

```sh
TeranJoanQuarkExamenModuloCSharp.exe
```

Se le debera hacer doble click, lo cual abrira el programa directamente en el menu principal que se vera asi:

```sh
=============================================================
Inicializacion programa de cotizacion
=============================================================

Seleccione una opcion:
1-Nueva Cotizacion
2-Ver Historial de Cotizaciones
3-Salir
```

## Revision del menu principal

Como se puede ver en el menu principal, tenemos 3 opciones.

1-Nueva Cotizacion: Abre un menu interactivo para generar una cotizacion nueva.
2-Ver Historial de Cotizaciones: Recorre la lista de cotizaciones realizadas y las imprime en pantalla.
3-Salir: Sale del programa.

```sh
=============================================================
Inicializacion programa de cotizacion
=============================================================

Seleccione una opcion:
1-Nueva Cotizacion
2-Ver Historial de Cotizaciones
3-Salir
```

## Realizar una nueva cotizacion

Lo primero sera entender que tipos de prendas podemos cotizar y sus propiedades.
En la version 0.1.0 disponemos de dos prendas: Remeras y Pantalones.

Remeras:

- Calidad Premium o Calidad Standard
- Cuello Comun o Cuello Mao
- Manga larga o manga corta

Pantalones:

- Calidad Premium o Calidad Standard
- Tipo chupin o comun

En segundo lugar, podremos elegir el precio base de la prenda, sin embargo se aplicaran recargos o descuentos segun las reglas de negocio.

- Dato no menor: Tener en cuenta que no se podran cotizar prendas que no se encuentren suficientes en Stock.

### Realizar nuestra primer cotizacion

En el menu principal, elegir la opcion 1 y apretar enter.

```sh
Seleccione una opcion:
1-Nueva Cotizacion
2-Ver Historial de Cotizaciones
3-Salir
1
```

Esto nos abrira el menu interactivo que nos permitira configurar la prenda a cotizar:

```sh
=============================================================
Crear nueva cotizacion.
=============================================================

Seleccione el tipo de prenda.
0-Pantalon
1-Camisa
```

Sigamos el menu segun deseemos, por ejemplo:

```sh
=============================================================
Crear nueva cotizacion.
=============================================================

Seleccione el tipo de prenda.
0-Pantalon
1-Camisa
0
Seleccione el la calidad de tela.
0-Standard
1-Premium
1
Seleccione el tipo de pantalon.
0-Comun
1-Chupin
0
Ingrese el valor de la prenda.
100
Ingrese la cantidad de prendas a cotizar.
7
```

Una vez que aceptemos la cantidad de prendas, se realizara la cotizacion, se mostrar en pantalla y se volvera a mostrar el menu principal:

```sh
=============================================================
Cotizacion realizada con exito:
Prenda:Pantalon de Calidad Premium de Tipo Comun, P/U $70. Stock 250 unidades. Cantidad cotizada:7, Valor total:$490
=============================================================

Seleccione una opcion:
1-Nueva Cotizacion
2-Ver Historial de Cotizaciones
3-Salir
```

## Que pasa si no hay Stock suficiente?

Suponiendo que cargamos una cotizacion y ponemos un numero mas alto del stock disponible.

```sh
=============================================================
Crear nueva cotizacion.
=============================================================

Seleccione el tipo de prenda.
0-Pantalon
1-Camisa
1
Seleccione el la calidad de tela.
0-Standard
1-Premium
1
Seleccione el tipo de mangas.
0-Manga Corta
1-Manga Larga
0
Seleccione el tipo de cuello.
0-Cuello Mao
1-Cuello Comun
1
Ingrese el valor de la prenda.
100
Ingrese la cantidad de prendas a cotizar.
7500
```

Nos mostrar un error y volveremos al menu principal.

```sh
=============================================================
Disculpe las molestias, no podemos cotizar la cantidad solicitada por falta de Stock. Por favor, realice una nueva cotizacion.
=============================================================

Seleccione una opcion:
1-Nueva Cotizacion
2-Ver Historial de Cotizaciones
3-Salir
```

## Mostrando el historial de cotizaciones

Suponiendo que hemos realizado varias cotizaciones nuevas, podremos mostrar el listado historico de cotizaciones.

```sh
=============================================================
Cotizacion realizada con exito:
Prenda:Camisa de Calidad Premium de Cuello Mao y Manga Corta, P/U $5,6699996. Stock 100 unidades. Cantidad cotizada:15, Valor total:$85,049995
=============================================================

Seleccione una opcion:
1-Nueva Cotizacion
2-Ver Historial de Cotizaciones
3-Salir
```

Podemos seleccionar la opcion 2, que nos mostrara el historial y volver al menu principal.

```sh
=============================================================
0- Prenda:Pantalon de Calidad Standard de Tipo Comun, P/U $100. Stock 250 unidades. Cantidad cotizada:10, Valor total:$1000
1- Prenda:Camisa de Calidad Standard de Cuello Mao y Manga Corta, P/U $2,7. Stock 100 unidades. Cantidad cotizada:10, Valor total:$27
2- Prenda:Pantalon de Calidad Premium de Tipo Chupin, P/U $107,8. Stock 750 unidades. Cantidad cotizada:36, Valor total:$3880,8
3- Prenda:Camisa de Calidad Premium de Cuello Mao y Manga Larga, P/U $4,725. Stock 75 unidades. Cantidad cotizada:14, Valor total:$66,15
=============================================================
Seleccione una opcion:
1-Nueva Cotizacion
2-Ver Historial de Cotizaciones
3-Salir
```

### Que pasa si aun no se han realizado cotizaciones?

Se mostrara un mensaje que aun no se han realizado cotizaciones y se vuelve al menu principal.

```sh
=============================================================
Aun no se han hecho cotizaciones.
=============================================================

Seleccione una opcion:
1-Nueva Cotizacion
2-Ver Historial de Cotizaciones
3-Salir
```

## Salir del programa

En el menu principal, podremos elegir la opcion 3 y esta nos sacara del programa.

```sh
=============================================================
Seleccione una opcion:
1-Nueva Cotizacion
2-Ver Historial de Cotizaciones
3-Salir
```

```sh
=============================================================
Saliendo del programa.
=============================================================
```

## Que pasa si elegimos una opcion no disponible?

En todos los casos que elijamos una opcion no disponible, ya sea porque es un numero de opcion inexistente, por ejemplo, elegir la opcion 7 en el menu principal, o escribir una letra o un simbolo, mostrara el mensaje de Opcion Incorrecta, Vuelve a intentarlo:

```sh
Opcion incorrecta. Vuelve a intentarlo.
Seleccione una opcion:
1-Nueva Cotizacion
2-Ver Historial de Cotizaciones
3-Salir
