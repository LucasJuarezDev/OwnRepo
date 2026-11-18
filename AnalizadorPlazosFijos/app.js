class Banco {
  constructor(nombre, tasas) {
    this.nombre = nombre;
    this.tasas = tasas; 
  }

  calcularPromedio() {
    let suma = 0;
    for (const tasa of this.tasas) {
      suma = suma + tasa;
    }
    const promedioEnPorcentaje = suma / this.tasas.length;
    return promedioEnPorcentaje / 100;
  }

  calcularGananciaAnual(capital) {
    return capital * this.calcularPromedio();
  }

  calcularGananciaCompuesta(capital, periodos) {
    const tasaDelPeriodo = this.calcularPromedio() / periodos;
    let monto = capital;
    for (let periodo = 1; periodo <= periodos; periodo++) {
      const gananciaDelPeriodo = monto * tasaDelPeriodo;
      monto = monto + gananciaDelPeriodo;
    }
    return monto - capital;
  }

  calcularRendimientos(capital) {
    return {
      anual: this.calcularGananciaAnual(capital),
      trimestral: this.calcularGananciaCompuesta(capital, 4),
      mensual: this.calcularGananciaCompuesta(capital, 12)
    };
  }
}
class AnalizadorInversiones {
  constructor(capital, bancos) {
    this.capital = capital;
    this.bancos = bancos;
    this.resultados = [];
  }

  analizar() {
    this.resultados = [];
    for (const banco of this.bancos) {
      const rendimientos = banco.calcularRendimientos(this.capital);
      this.resultados.push({ banco: banco, rendimientos: rendimientos });
    }
  }

  obtenerMejorOpcion() {
    let mejorOpcion = null;
    for (const resultado of this.resultados) {
      const opciones = [
        { modalidad: 'anual', ganancia: resultado.rendimientos.anual },
        { modalidad: 'trimestral', ganancia: resultado.rendimientos.trimestral },
        { modalidad: 'mensual', ganancia: resultado.rendimientos.mensual }
      ];
      for (const opcion of opciones) {
        if (mejorOpcion === null || opcion.ganancia > mejorOpcion.ganancia) {
          mejorOpcion = {
            banco: resultado.banco.nombre,
            modalidad: opcion.modalidad,
            ganancia: opcion.ganancia
          };
        }
      }
    }
    return mejorOpcion;
  }
}


// ========================================================


const BANCOS_DEL_FORMULARIO = [
  { nombre: 'Banco Nación', prefijoId: 'nacion' },
  { nombre: 'Banco Provincia', prefijoId: 'provincia' },
  { nombre: 'Banco Hipotecario', prefijoId: 'hipotecario' }
];
const ANIOS = [2023, 2024, 2025];


function leerCampo(id, etiqueta) {
  const texto = document.getElementById(id).value.trim();
  const numero = Number(texto.replace(',', '.'));
  return { id: id, etiqueta: etiqueta, texto: texto, numero: numero };
}


function leerDatosDelFormulario() {
  const datos = { capital: leerCampo('capital', 'Capital a invertir'), bancos: [] };
  for (const banco of BANCOS_DEL_FORMULARIO) {
    const campos = [];
    for (const anio of ANIOS) {
      const id = `${banco.prefijoId}-${anio}`;
      campos.push(leerCampo(id, `${banco.nombre} - TNA ${anio}`));
    }
    datos.bancos.push({ nombre: banco.nombre, campos: campos });
  }
  return datos;
}

function validarCampo(campo, esCapital) {
  if (campo.texto === '') {
    return `Completá el campo "${campo.etiqueta}".`;
  }
  if (!Number.isFinite(campo.numero)) {
    return `En "${campo.etiqueta}" solo podés escribir números (sin letras ni símbolos).`;
  }
  if (campo.numero < 0) {
    return `En "${campo.etiqueta}" no se permiten números negativos.`;
  }
  if (esCapital && campo.texto.includes('.')) {
    return `Escribí el "${campo.etiqueta}" sin puntos (ej: 850000). Si tiene centavos, usá coma (ej: 850000,50).`;
  }
  if (esCapital && campo.numero === 0) {
    return `El "${campo.etiqueta}" tiene que ser mayor a 0.`;
  }
  return '';
}

function validarDatos(datos) {
  const errores = [];
  const errorCapital = validarCampo(datos.capital, true);
  if (errorCapital !== '') {
    errores.push({ id: datos.capital.id, mensaje: errorCapital });
  }
  for (const banco of datos.bancos) {
    for (const campo of banco.campos) {
      const error = validarCampo(campo, false);
      if (error !== '') {
        errores.push({ id: campo.id, mensaje: error });
      }
    }
  }
  return errores;
}

function crearBancos(datos) {
  const bancos = [];
  for (const banco of datos.bancos) {
    const tasas = [];
    for (const campo of banco.campos) {
      tasas.push(campo.numero);
    }
    bancos.push(new Banco(banco.nombre, tasas));
  }
  return bancos;
}

function formatearPesos(numero) {
  return numero.toLocaleString('es-AR', { style: 'currency', currency: 'ARS' });
}

function formatearPorcentaje(numeroDecimal) {
  return (numeroDecimal * 100).toLocaleString('es-AR', { maximumFractionDigits: 2 }) + '%';
}

function limpiarPantalla() {
  document.getElementById('zona-errores').hidden = true;
  document.getElementById('zona-resultados').hidden = true;
  for (const input of document.querySelectorAll('input')) {
    input.classList.remove('input-error');
  }
}

function mostrarErrores(errores) {
  let lista = '';
  for (const error of errores) {
    lista += `<li>${error.mensaje}</li>`;
    document.getElementById(error.id).classList.add('input-error');
  }
  const zonaErrores = document.getElementById('zona-errores');
  zonaErrores.innerHTML = `<strong>No se puede calcular. Revisá estos datos:</strong><ul>${lista}</ul>`;
  zonaErrores.hidden = false;
  document.getElementById(errores[0].id).focus();
}

function mostrarResultados(analizador) {
  let filas = '';
  for (const resultado of analizador.resultados) {
    filas += `
      <tr>
        <td>${resultado.banco.nombre}</td>
        <td>${formatearPorcentaje(resultado.banco.calcularPromedio())}</td>
        <td>${formatearPesos(resultado.rendimientos.anual)}</td>
        <td>${formatearPesos(resultado.rendimientos.trimestral)}</td>
        <td>${formatearPesos(resultado.rendimientos.mensual)}</td>
      </tr>`;
  }
  document.getElementById('capital-invertido').textContent = formatearPesos(analizador.capital);
  document.getElementById('cuerpo-tabla').innerHTML = filas;

  const mejor = analizador.obtenerMejorOpcion();
  const recomendacion = document.getElementById('recomendacion');
  if (mejor.ganancia > 0) {
    recomendacion.textContent = `Te conviene invertir en el ${mejor.banco}, de forma ${mejor.modalidad}, ` +
      `con una ganancia de ${formatearPesos(mejor.ganancia)}.`;
  } else {
    recomendacion.textContent = 'Con todas las tasas en 0% ninguna opción genera ganancia.';
  }
  document.getElementById('zona-resultados').hidden = false;
}

document.getElementById('boton-calcular').addEventListener('click', function () {
  limpiarPantalla();

  const datos = leerDatosDelFormulario();
  const errores = validarDatos(datos);
  if (errores.length > 0) {
    mostrarErrores(errores);
    return;
  }

  const bancos = crearBancos(datos);
  const analizador = new AnalizadorInversiones(datos.capital.numero, bancos);
  analizador.analizar();
  mostrarResultados(analizador);
});
