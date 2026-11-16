# Guiones para los videos

> Tip: con **Ctrl+Shift+V** lo ves con formato (vista previa de Markdown).

**Datos para cargar en el video**

- Capital: `850000`
- Banco Nación: `120` / `90` / `26`
- Banco Provincia: `110` / `95` / `24`
- Banco Hipotecario: `125` / `88` / `27`

En cada paso:
🗣️ **Decís** = lo que hablás ·
💻 **Código** = qué archivo y qué líneas mostrás ·
🖥️ **Página** = qué hacés o qué se ve en el navegador

---
---

# GUION 1 — Video de funcionamiento (2-3 min)

### PASO 1 — Presentación `0:00`

- 🖥️ **Página:** la página recién abierta, con el formulario vacío.
- 🗣️ **Decís:** "Hola, soy ___. Les muestro mi Analizador de Plazos Fijos. Cargás un capital y las tasas de tres bancos, y el programa te dice dónde y cómo te conviene invertir."

### PASO 2 — El formulario `0:15`

- 🖥️ **Página:** señalás el input del capital y después las 3 tarjetas.
- 🗣️ **Decís:** "Arriba va el capital. El 850.000 que está en gris es solo un ejemplo, no está fijo. Abajo hay una tarjeta por banco: Nación, Provincia e Hipotecario. Cada una pide la TNA de 2022, 2023 y 2024. Van en porcentaje: si escribo 120, es 120%."

### PASO 3 — Cargar los datos `0:35`

- 🖥️ **Página:** escribís los 10 valores de arriba.
- 🗣️ **Decís:** "Cargo 850.000 de capital. Nación: 120, 90 y 26. Provincia: 110, 95 y 24. Hipotecario: 125, 88 y 27."

### PASO 4 — Calcular `0:55`

- 🖥️ **Página:** clic en **Calcular**. Aparece la sección Resultados.
- 🗣️ **Decís:** "Le doy a Calcular. Arriba me confirma el capital que invertí: 850.000 pesos."

### PASO 5 — Los promedios `1:05`

- 🖥️ **Página:** señalás la columna **TNA promedio** (78,67% / 76,33% / 80%).
- 🗣️ **Decís:** "Hay una fila por banco. Esta columna es el promedio de las tres tasas de cada uno."

### PASO 6 — Las 9 ganancias `1:15`

- 🖥️ **Página:** recorrés con el mouse las columnas Anual, Trimestral y Mensual. Después señalás el texto "Rendimiento = solo la ganancia".
- 🗣️ **Decís:** "Estas tres columnas son las 9 ganancias: anual, trimestral y mensual, para cada banco. Ojo: es solo lo que ganás. No incluye el capital que pusiste."

### PASO 7 — Ejemplo con el Hipotecario `1:30`

- 🖥️ **Página:** señalás la fila del Hipotecario, celda por celda.
- 🗣️ **Decís:** "Por ejemplo, el Hipotecario. Si dejás la plata un año entero, ganás 680.000. Si reinvertís cada tres meses, ganás 912.560. Y si reinvertís todos los meses, ganás 994.011."

### PASO 8 — Por qué la mensual gana más `1:45`

- 🖥️ **Página:** señalás de izquierda a derecha cómo crecen los números en cada fila.
- 🗣️ **Decís:** "Fijate que en los tres bancos la mensual gana más y la anual menos. No es un error: cuanto más seguido reinvertís, más ganás."

### PASO 9 — La recomendación `1:55`

- 🖥️ **Página:** señalás el cartel verde de abajo.
- 🗣️ **Decís:** "Y abajo el cartel lo dice clarito: te conviene invertir en el Banco Hipotecario, de forma mensual, con una ganancia de 994.011 pesos con 43."

### PASO 10 — Otro capital `2:05`

- 🖥️ **Página:** borrás el capital, escribís `2435000` y clic en **Calcular**. El cartel ahora dice $ 2.847.550,39.
- 🗣️ **Decís:** "Ahora cambio solo el capital: pongo 2.435.000 y calculo de nuevo. Se recalcula todo. El Hipotecario mensual ahora da 2.847.550 pesos. O sea, el capital no está fijo en el código: usa lo que vos cargás."

### PASO 11 — Validaciones: letra, negativo y vacío `2:20`

- 🖥️ **Página:** en Nación 2023 escribís `abc`, en Provincia 2023 escribís `-5` y borrás Hipotecario 2024. Clic en **Calcular**. Desaparece la tabla y aparece la caja roja.
- 🗣️ **Decís:** "Ahora pruebo las validaciones. En Nación 2023 escribo letras, en Provincia 2023 un negativo, y Hipotecario 2024 lo dejo vacío. Calculo. No calcula nada. Me dice qué campo está mal y por qué, me marca los tres en rojo y me deja el cursor en el primero."

### PASO 12 — Capital en cero `2:40`

- 🖥️ **Página:** en el capital escribís `0` y clic en **Calcular**.
- 🗣️ **Decís:** "Si pongo el capital en cero, me avisa que tiene que ser mayor a cero."

### PASO 13 — Cierre `2:50`

- 🖥️ **Página:** cargás de nuevo los datos buenos y clic en **Calcular**. Vuelven la tabla y el cartel.
- 🗣️ **Decís:** "Corrijo todo, calculo y vuelve a andar. Eso es todo, ¡gracias!"

---
---

# GUION 2 — Video de explicación del código (3-5 min)

> Tené la página abierta al costado (o en otra pestaña), así mostrás qué parte de la pantalla llena cada bloque.

### PASO 1 — Los archivos `0:00`

- 💻 **Código:** el explorador de VS Code con los 3 archivos. Abrís `estilos.css` un segundo y lo cerrás.
- 🗣️ **Decís:** "Ahora les explico el código. Son tres archivos: index.html, estilos.css y app.js. El CSS es solo para que se vea prolijo, así que me enfoco en el HTML y en app.js."

### PASO 2 — El formulario en el HTML `0:15`

- 💻 **Código:** `index.html`, líneas **18 a 56**. Después señalás la línea **30**.
- 🗣️ **Decís:** "De acá a acá está el formulario: el input del capital y las tres tarjetas de los bancos. Cada input tiene un id, por ejemplo nacion-2022. Con ese id, JavaScript lee lo que escribiste. Los inputs son de tipo texto a propósito: así, si alguien escribe una letra, la detectamos y le avisamos."
- 🖥️ **Página:** el formulario.

### PASO 3 — Botón, errores y resultados en el HTML `0:40`

- 💻 **Código:** `index.html`, líneas **58 a 84**. Señalás `hidden`, la línea **79** (`cuerpo-tabla`) y la línea **88** (`app.js`).
- 🗣️ **Decís:** "Acá está el botón Calcular, la caja de errores y la sección de resultados. Las dos últimas arrancan ocultas. La tabla tiene el cuerpo vacío: lo llena JavaScript. Y al final se carga app.js."
- 🖥️ **Página:** el botón Calcular.

### PASO 4 — Cómo está ordenado app.js `1:00`

- 💻 **Código:** `app.js`, líneas **1 a 6**. Después bajás hasta la línea **95**.
- 🗣️ **Decís:** "app.js tiene dos partes. La parte 1 es la lógica: las clases que hacen las cuentas, sin tocar la página. La parte 2 es todo lo que lee y escribe en la página."

### PASO 5 — Clic en Calcular `1:15`

- 💻 **Código:** `app.js`, BLOQUE 7, líneas **238 a 254**.
- 🗣️ **Decís:** "Voy en el orden en que se ejecuta. Todo arranca acá abajo, cuando hacés clic en Calcular. Es como una receta: limpia la pantalla, lee los datos y los valida. Si hay errores, los muestra y corta acá. Si está todo bien, crea los bancos, analiza y muestra los resultados."
- 🖥️ **Página:** clic en **Calcular**.

### PASO 6 — Leer el formulario `1:40`

- 💻 **Código:** `app.js`, BLOQUE 3, líneas **97 a 126**. Señalás la línea **120**.
- 🗣️ **Decís:** "Primero se leen los datos. Acá tengo la lista de bancos y de años. Con eso armo el id de cada input: nacion-2022, nacion-2023, y así. Leo los 10 valores sin repetir código. leerCampo guarda lo que escribiste y ya lo pasa a número. Si usás coma, como 75,5, también lo entiende."
- 🖥️ **Página:** los 10 inputs.

### PASO 7 — Validar `2:05`

- 💻 **Código:** `app.js`, BLOQUE 4, líneas **128 a 165**.
- 🗣️ **Decís:** "Después se valida. validarCampo revisa en orden: si está vacío, si no es número y si es negativo. Al capital además le pide que no tenga puntos y que sea mayor a cero. Si algo falla, devuelve el mensaje: son los mismos textos de la caja roja. validarDatos pasa por los 10 campos y junta todos los errores en una lista."

### PASO 8 — Mostrar errores `2:30`

- 💻 **Código:** `app.js`, `mostrarErrores`, líneas **198 a 209**.
- 🗣️ **Decís:** "Si la lista tiene algo, mostrarErrores arma la caja roja, pinta los inputs en rojo y pone el cursor en el primero."
- 🖥️ **Página:** la caja roja con los inputs en rojo.

### PASO 9 — Crear los bancos `2:40`

- 💻 **Código:** `app.js`, BLOQUE 5, líneas **167 a 178**.
- 🗣️ **Decís:** "Si no hay errores, crearBancos agarra las tres tasas de cada banco y crea un objeto Banco."

### PASO 10 — Por qué usamos clases `2:50`

- 💻 **Código:** `app.js`, `class Banco`, líneas **8 a 14**.
- 🗣️ **Decís:** "¿Por qué clases? Porque cada banco guarda sus propias tasas y sabe calcular sus propias ganancias. Así queda todo ordenado."
- 🖥️ **Página:** las 3 filas de la tabla, una por banco.

### PASO 11 — El promedio `3:00`

- 💻 **Código:** `calcularPromedio`, líneas **16 a 24**.
- 🗣️ **Decís:** "calcularPromedio suma las tres tasas, divide por tres y después por cien, para pasar de porcentaje a decimal. Este método llena la columna TNA promedio."
- 🖥️ **Página:** la columna TNA promedio.

### PASO 12 — La ganancia anual `3:10`

- 💻 **Código:** `calcularGananciaAnual`, líneas **26 a 29**.
- 🗣️ **Decís:** "La anual es la más simple: capital por tasa. Esto llena la columna Anual."
- 🖥️ **Página:** la columna Anual.

### PASO 13 — La ganancia con reinversión `3:20`

- 💻 **Código:** `calcularGananciaCompuesta`, líneas **31 a 41**. Señalás la línea **34**, el for (**36 a 39**) y la línea **40**.
- 🗣️ **Decís:** "Este es el método más importante. Sirve para trimestral y para mensual: solo cambia la cantidad de períodos. Divido la tasa anual por 4 o por 12. En cada vuelta calculo lo que ganó ese período y se lo sumo a la plata. Al final devuelvo la plata final menos el capital. O sea, solo la ganancia, que es lo que pide el enunciado."
- 🖥️ **Página:** las columnas Trimestral y Mensual.

### PASO 14 — La bola de nieve `3:45`

- 💻 **Código:** línea **38** (`monto = monto + gananciaDelPeriodo`).
- 🗣️ **Decís:** "Por eso la mensual siempre gana más. La ganancia se reinvierte todos los meses: es una bola de nieve. Cada mes la bola es más grande y gana un poco más. En el Hipotecario, el primer mes gana 56.666 pesos y el último ya gana 115.250, con la misma tasa."
- 🖥️ **Página:** la columna Mensual, que es la más alta.

### PASO 15 — Las tres juntas `4:00`

- 💻 **Código:** `calcularRendimientos`, líneas **43 a 50**. Señalás el 4 y el 12.
- 🗣️ **Decís:** "calcularRendimientos junta las tres: la anual, la compuesta con 4 y la compuesta con 12. Esto es una fila de la tabla."
- 🖥️ **Página:** una fila completa.

### PASO 16 — La clase AnalizadorInversiones `4:10`

- 💻 **Código:** `app.js`, BLOQUE 2, líneas **53 a 69**.
- 🗣️ **Decís:** "La segunda clase es AnalizadorInversiones. Recibe el capital y los tres bancos. analizar le pide a cada banco sus ganancias y las guarda. Son los 9 números de la tabla."
- 🖥️ **Página:** las 9 celdas.

### PASO 17 — La mejor opción `4:25`

- 💻 **Código:** `obtenerMejorOpcion`, líneas **71 a 91**. Señalás el if de la línea **81**.
- 🗣️ **Decís:** "obtenerMejorOpcion recorre las 9 combinaciones: por cada banco mira la anual, la trimestral y la mensual, y se va quedando con la que más gana. Devuelve el banco, la modalidad y la ganancia. Eso es lo que sale en el cartel."
- 🖥️ **Página:** el cartel verde.

### PASO 18 — Mostrar los resultados `4:40`

- 💻 **Código:** `app.js`, BLOQUE 6: `formatearPesos` (líneas **181 a 183**) y `mostrarResultados` (líneas **211 a 236**).
- 🗣️ **Decís:** "Con todo calculado volvemos a la página. formatearPesos pone el número en pesos argentinos: signo peso, puntos de miles y coma. mostrarResultados arma una fila por banco con el nombre, el promedio y las tres ganancias. Después escribe el cartel con la recomendación y muestra la sección."
- 🖥️ **Página:** la tabla y el cartel.

### PASO 19 — Cierre `4:55`

- 💻 **Código:** scroll rápido por `app.js` de arriba a abajo.
- 🗣️ **Decís:** "Resumiendo: el HTML tiene el formulario, el botón arranca todo, se lee y se valida, las clases hacen las cuentas y la parte 2 lo muestra. ¡Gracias!"
