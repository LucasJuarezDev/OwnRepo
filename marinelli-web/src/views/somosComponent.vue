<template>
    <section class="somos1">
      <div class="parent">
        <h1 class="titulo">fletes marinelli</h1>
        <hr>
      </div>
      <div class="child2">
        <h2 class="slogan">Tu flete de confianza, a un click.</h2>
      </div>
      <div class="child1" @mouseover="Ocultar = true" @mouseleave="Ocultar = false">
        <h3 class="subtitulo">¿Quiénes Somos?</h3>
        <p class="texto" v-if="Ocultar">
          Oriundos de la Zona Norte de Buenos Aires, somos un emprendimiento orientado a la logística 
          requerida ya sea para una mudanza, como también para el translado de 
          materiales para una empresa particular. <strong>Trabajamos con mucho 
          empeño</strong> para que cada obstáculo sea resuelto de la forma más 
          óptima para nuestros clientes.
        </p>
      </div>
    </section>
    </template>
  
  <script>
  export default {
      data(){
          return{
            Ocultar: false,
          }
      }
  }
  </script>
  
  <style scoped>
.somos1 {
  display: flex;
  justify-content: center;
  align-items: center;
  height: 100vh; /* Ocupa toda la ventana */
  background-color: white;
  background-image: linear-gradient(to top, white , slateblue);
  color: black;
  text-align: center;
}


.titulo{
  color:white;
  font-family:'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif;
  font-size: 40px;
  text-transform: uppercase;
  margin-bottom: 2.5em;
  letter-spacing: 25px;
  margin-bottom: 0;
}

hr{
  margin: 0;
  border: none; /* Quita el borde predeterminado */
  border-top: 2px solid white; /* Línea superior más gruesa */
  width: 97%;
}

.parent{
  position: absolute;
  top: 10%;
}

.child2{
  position: absolute;
  top: 27%;
}

/* Contenido centrado */
.child1 {
  position: relative;
  top: 2%;
  width: 80%;
  max-width: 600px;
  border-radius: 8px;
  box-shadow: 0px 4px 6px rgba(0, 0, 0, 0.1);
  padding: 20px;
  color: black;
}

.slogan{
  font-family:Arial, Helvetica, sans-serif;
  font-size: 1.5em;
  text-transform: uppercase;
  margin-bottom: 20px;
  color: white; 
}

/* Estilo del título */
.subtitulo {
  font-family:Arial, Helvetica, sans-serif;
  font-size: 40px;
  text-transform: uppercase;
  margin-bottom: 20px;
  color: slateblue; 
}

/* Estilo del texto */
.texto {
  font-family: 'Times New Roman', Times, serif;
  font-size: 20px;
  line-height: 1.6;
  color:white;
}

.texto strong {
  color: slateblue;
}
</style>