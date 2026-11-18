# Guiones para los videos

> Tip: con **Ctrl+Shift+V** lo ves con formato (vista previa de Markdown).

---

# Video de funcionamiento (2-3 min)

**Datos para cargar:** capital `850000` · Nación `120` / `90` / `26` · Provincia `110` / `95` / `24` · Hipotecario `125` / `88` / `27`

**[página recién abierta, formulario vacío]** Hola, soy Lucas Juárez, del turno noche. Este es el video de funcionamiento del Segundo Parcial: un analizador de plazos fijos. La idea es simple: cargás un capital y las tasas de tres bancos, y el programa te dice dónde y cómo te conviene invertir.

**[señalo el input del capital]** Arriba va el capital que querés invertir. **[señalo las tres tarjetas]** Abajo hay una tarjeta por banco: Nación, Provincia e Hipotecario. Cada una pide la TNA de 2023, 2024 y 2025, que son los últimos tres años completos. Y las tasas van en porcentaje, o sea, si escribo 120 es 120%.

**[cargo los datos de prueba]** Entonces cargo 850.000 de capital. En Nación pongo 120, 90 y 26. En Provincia, 110, 95 y 24. Y en Hipotecario, 125, 88 y 27.

**[clic en Calcular]** Le doy a Calcular y aparecen los resultados. **[señalo "Capital invertido"]** Arriba me confirma el capital que puse.

**[señalo la columna TNA promedio]** Primero, la TNA es la Tasa Nominal Anual, o sea, el porcentaje que te paga el banco por año sobre la plata que dejás. Pero fijate que las tasas cambiaron un montón de un año a otro: el Nación pagaba 120% en 2023 y 26% en 2025. Entonces, para tener un solo número por banco y poder compararlos parejo, el programa promedia las tres tasas. **[señalo la celda del Nación]** Por ejemplo, el Nación: 120 más 90 más 26 da 236, dividido 3 da 78,67%. **[señalo las otras dos celdas]** El Provincia da 76,33% y el Hipotecario 80%. Y ese promedio es la tasa que se usa para calcular todas las ganancias.

**[recorro las columnas Anual, Trimestral y Mensual]** Después están las tres formas de invertir. **[señalo la columna Anual]** En la anual dejás la plata quieta un año entero y cobrás el interés una sola vez, al final. **[señalo la columna Trimestral]** En la trimestral hacés un plazo fijo de tres meses y, cuando vence, lo renovás con el capital más lo que ganaste. Eso se repite cuatro veces en el año. **[señalo la columna Mensual]** Y la mensual es lo mismo, pero renovando todos los meses, o sea, doce veces. Entonces, tres formas por tres bancos: esas son las 9 ganancias de la tabla.

**[señalo la fila del Hipotecario, celda por celda]** Por ejemplo, el Hipotecario. Si dejás la plata quieta un año entero, ganás 680.000. Si reinvertís cada tres meses, ganás 912.560. Y si reinvertís todos los meses, ganás 994.011.

**[señalo la columna Mensual]** Fijate que en los tres bancos la mensual es la que más gana. Y tiene sentido: cada mes la ganancia se suma a la plata, entonces el mes siguiente ganás intereses también sobre eso. Es como una bola de nieve: cuanto más seguido reinvertís, más rápido crece.

**[señalo el cartel verde]** Y abajo el cartel te lo dice directo: te conviene invertir en el Banco Hipotecario, de forma mensual, con una ganancia de 994.011 pesos con 43.

**[cambio el capital a 2435000 y clic en Calcular]** Ahora cambio solo el capital, pongo 2.435.000, y calculo de nuevo. Se recalcula todo, y el Hipotecario mensual ahora da 2.847.550 pesos. O sea, el programa trabaja con lo que vos cargás, no con números fijos.

**[en Nación 2024 escribo `abc`, borro Hipotecario 2025 y clic en Calcular]** Una prueba rápida: si escribo letras o dejo un campo vacío, no calcula. Me dice qué campo está mal, me lo marca en rojo y me deja el cursor ahí. **[vuelvo a poner 90 y 27, clic en Calcular]** Lo corrijo, calculo y vuelve a andar.

Y eso es todo, gracias.

---

# Video del código (4-5 min)

**Datos para cargar:** capital `850000` · Nación `120` / `90` / `26` · Provincia `110` / `95` / `24` · Hipotecario `125` / `88` / `27`

**[app.js abierto, arriba de todo]** Hola, soy Lucas Juárez, del turno noche. Este es el video del código del Segundo Parcial. Todo el funcionamiento está en app.js, así que lo voy a recorrer de arriba hacia abajo.

**[app.js, líneas 1-3]** El archivo está dividido en dos partes. La parte 1 es la lógica: dos clases, `Banco` y `AnalizadorInversiones`, que hacen todas las cuentas y no tocan la página. La parte 2 es la que habla con la página: lee lo que cargaste, lo valida y muestra los resultados. Separarlo sirve para que las cuentas no dependan de cómo está armada la pantalla.

**[app.js, líneas 10-14: `class Banco`]** Arranco con la clase `Banco`. Cada banco guarda su `nombre` y sus `tasas`, que son las tres TNA en porcentaje. ¿Por qué una clase? Porque cada banco tiene sus propios datos y sabe hacer sus propias cuentas, entonces todo lo de un banco queda junto en un objeto.

**[app.js, líneas 17-24: `calcularPromedio`]** El primer método es `calcularPromedio`. **[líneas 18-21]** Recorre `this.tasas` y las va sumando en `suma`. **[línea 22]** Después divide por `this.tasas.length`, o sea por la cantidad de tasas, y eso queda en `promedioEnPorcentaje`. **[línea 23]** Y al final lo divide por cien para pasarlo a decimal. Por ejemplo, en el Hipotecario: 125 más 88 más 27 da 240, dividido 3 da 80, y dividido 100 queda 0,8. **[página: columna TNA promedio]** Esto llena la columna TNA promedio, y es la tasa que usan todas las demás cuentas.

**[app.js, líneas 27-29: `calcularGananciaAnual`]** Después viene `calcularGananciaAnual`, que es la más simple: **[línea 28]** `capital` por `calcularPromedio()`, porque en la anual cobrás el interés una sola vez. En el Hipotecario, 850.000 por 0,8 da 680.000. **[página: columna Anual]** Esa es la columna Anual.

**[app.js, líneas 33-41: `calcularGananciaCompuesta`]** Y este es el método más importante, `calcularGananciaCompuesta`. Recibe el `capital` y los `periodos`, y sirve para la trimestral y la mensual: lo único que cambia es si `periodos` vale 4 o 12. **[línea 34]** Primero calcula `tasaDelPeriodo`, que es la tasa anual dividida por los períodos. En el Hipotecario mensual es 0,8 dividido 12, o sea, 6,67% por mes. **[línea 35]** `monto` arranca valiendo el capital. **[líneas 36-39]** Y en cada período **[línea 37]** calcula `gananciaDelPeriodo`, que es el monto por la tasa del período, **[línea 38]** y se la suma al `monto`. Esta línea es la bola de nieve: la ganancia queda adentro, entonces el período siguiente gana sobre una plata más grande. En el Hipotecario, el primer mes gana 56.666 pesos y el último ya gana 115.250, con la misma tasa. **[línea 40]** Al final devuelve `monto - capital`, o sea, solo la ganancia, sin el capital que pusiste.

**[app.js, líneas 44-50: `calcularRendimientos`]** `calcularRendimientos` junta las tres en un objeto: **[líneas 46-48]** `anual`, `trimestral`, que llama a la compuesta con 4, y `mensual`, que la llama con 12. **[página: fila del Hipotecario]** Eso es una fila entera de la tabla.

**[app.js, líneas 55-60: `class AnalizadorInversiones`]** La segunda clase es `AnalizadorInversiones`, y sirve para comparar los bancos entre sí. Recibe el `capital` y la lista de `bancos`, y tiene `resultados`, que arranca vacío.

**[app.js, líneas 63-69: `analizar`]** `analizar` recorre los bancos, **[línea 66]** a cada uno le pide `calcularRendimientos` **[línea 67]** y guarda el banco con sus rendimientos en `resultados`. Ahí quedan los 9 números de la tabla.

**[app.js, líneas 72-91: `obtenerMejorOpcion`]** Y `obtenerMejorOpcion` elige la mejor. **[línea 73]** `mejorOpcion` arranca en null. **[líneas 75-79]** Por cada banco arma la lista `opciones` con sus tres modalidades, **[línea 81]** y si una opción gana más que la `mejorOpcion` que tenía guardada, la reemplaza. Entonces, después de pasar por las 9, **[línea 90]** devuelve el banco, la modalidad y la ganancia de la que más gana. **[página: cartel verde]** Eso es lo que dice el cartel.

**[app.js, línea 95]** Hasta acá la lógica. La parte 2 la paso más rápido. **[app.js, líneas 99-104: `BANCOS_DEL_FORMULARIO` y `ANIOS`]** Acá están las listas de bancos y de años. **[app.js, líneas 108-112: `leerCampo`]** `leerCampo` busca el input con `getElementById`, agarra lo que escribiste con `value` y lo guarda como texto, para validar, y como número, para las cuentas. Si usaste coma, la pasa a punto. **[app.js, líneas 115-126: `leerDatosDelFormulario`]** Y `leerDatosDelFormulario` combina las dos listas **[línea 120]** para armar cada id, tipo nacion-2023, y así lee los 10 valores sin repetir código.

**[app.js, líneas 128-165: `validarCampo` y `validarDatos`]** Después, `validarCampo` y `validarDatos` revisan que nada esté vacío, que sean números, que no sean negativos y que el capital sea mayor a cero. Si algo falla, juntan los mensajes de error.

**[app.js, líneas 168-178: `crearBancos`]** `crearBancos` agarra las tasas ya validadas de cada banco **[línea 175]** y crea un `new Banco` con ellas. O sea, es el puente entre el formulario y las clases.

**[app.js, líneas 181-209]** Después hay funciones chicas para la pantalla: `formatearPesos` y `formatearPorcentaje` le dan formato a los números, `limpiarPantalla` borra lo anterior y `mostrarErrores` arma la caja roja.

**[app.js, líneas 212-236: `mostrarResultados`]** `mostrarResultados` arma una fila por banco con el nombre, el promedio y las tres ganancias, **[línea 225]** y las mete en la tabla con `innerHTML`. **[línea 227]** Después llama a `obtenerMejorOpcion`, **[líneas 229-234]** escribe el cartel con esa opción **[línea 235]** y muestra la sección.

**[app.js, líneas 240-254: el clic en Calcular]** Y abajo de todo está lo que une todo: el clic en Calcular. **[líneas 241-253]** Llama a `limpiarPantalla`, lee con `leerDatosDelFormulario` y valida con `validarDatos`. Si hay errores, los muestra y corta. Si está todo bien, usa `crearBancos`, crea el `AnalizadorInversiones`, llama a `analizar` y después a `mostrarResultados`.

**[página: la tabla y el cartel]** Resumiendo: la parte 2 lee y valida lo que cargás, las clases calculan el promedio, las 9 ganancias y la mejor opción, y la parte 2 lo muestra en la página. Eso es todo, gracias.

---

# Preparación para la defensa

## Preguntas que te puede hacer

- **¿Por qué 2023, 2024 y 2025 y no 2022 a 2024?**
  "Porque estamos en 2026, entonces los últimos tres años completos son 2023, 2024 y 2025. El 2026 todavía no terminó, así que no tengo la tasa del año entero."

- **¿Por qué usaste clases?**
  "Porque cada banco tiene sus datos, el nombre y las tasas, y sus propias cuentas, entonces tiene sentido que vayan juntos en un objeto. Y el AnalizadorInversiones se encarga de comparar los bancos entre sí. Así cada cosa tiene su lugar y no ando pasando tasas de función en función."

- **¿Por qué no usaste Math.pow?**
  "Con Math.pow sale en una línea y da exactamente lo mismo: capital por (1 + tasa / períodos) a la cantidad de períodos, menos el capital. Pero con el for se ve paso a paso cómo cada ganancia se reinvierte, que es justo la bola de nieve que quería mostrar. Lo elegí para que se entienda, no porque Math.pow esté mal."

- **¿Por qué el rendimiento es solo la ganancia?**
  "Porque es lo que pide el enunciado, y porque es lo que te interesa comparar: cuánta plata extra te deja cada opción. El capital es el mismo para todas, así que sumarlo no cambia cuál gana. Solo agrega un número que ya sabés."

- **¿Para qué separaste la lógica de la parte de la página?**
  "Para que las cuentas no dependan del HTML. Las clases no leen ni escriben nada en la pantalla: reciben números y devuelven números. Entonces si cambio el diseño de la página, las cuentas no las toco, y si quiero probar las cuentas, las pruebo sin abrir la página."

## Modificaciones que te pueden pedir

Solo dónde tocar. El código lo armás vos.

- **Agregar un 4° banco**
  - `index.html`: una tarjeta nueva dentro de la grilla, después de la del Hipotecario (líneas 47-55) y antes del cierre del div (línea 56). Copiá el patrón de ids.
  - `app.js`: la lista `BANCOS_DEL_FORMULARIO` (líneas 99-103). El prefijo tiene que coincidir con los ids del HTML.
  - Para pensar: ¿por qué no hace falta tocar las clases, la validación ni la tabla? (El CSS tampoco: la grilla se acomoda sola).
  - Prolijidad: los comentarios que dicen "3 bancos", "9" o "10 valores" (`app.js` líneas 54, 71, 114 y 149; `index.html` línea 25).

- **Agregar modalidad semestral**
  - `app.js`: `calcularRendimientos` (líneas 43-50). Pensá cuántos períodos tiene un año en semestres.
  - `app.js`: la lista de opciones de `obtenerMejorOpcion` (líneas 75-79), para que la semestral también compita.
  - `app.js`: la fila que arma `mostrarResultados` (líneas 215-222), una celda más.
  - `index.html`: el encabezado de la tabla (líneas 71-77), una columna más en el mismo orden que las celdas.
  - Para pensar: ¿por qué `calcularGananciaCompuesta` (líneas 31-41) no se toca?

- **Pasar de 3 a 4 años de historial**
  - `app.js`: la lista `ANIOS` (línea 104). Ojo con qué año agregás y dónde.
  - `index.html`: un label y un input más en cada tarjeta (Nación 29-34, Provincia 39-44, Hipotecario 49-54).
  - `index.html`: el texto de ayuda que dice "últimos 3 años" (línea 14).
  - Para pensar: ¿por qué `calcularPromedio` (líneas 16-24) sigue andando sin cambios?
  - Prolijidad: los comentarios de `app.js` líneas 9, 13 y 114, e `index.html` línea 25.
