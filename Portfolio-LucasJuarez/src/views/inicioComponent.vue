<template>
    <div class="ContenedorPrincipal">
      <header><cabezaComponent></cabezaComponent> </header>
      <div class="inicioContent">
        <div id="imagen"> 
          <img src="../assets/foto perfil.png" alt="fotolucas" class="foto">
        </div>
        <div id="info">
          <h1 class="titulo">Lucas Juarez</h1>
          <h2 class="subtitulo">Developer Trainee</h2>
          <hr id="divisoraInicio">
          <p class="descripcion">
              Estoy en busqueda de un puesto donde pueda desarrollarme como programador, orientado al 
              backend o al frontend, donde pueda aplicar mis conocimientos en <strong>C#, SQL Server, JavaScript, Vue.js, entre otras tecnologías.</strong> 
              Estoy mentalizado a chocar contra lo nuevo, aprenderlo, y volver a estar preparado
              para la misma situacion, me considero autodidacta con el tema de las tecnologias.
          </p>
        </div>
      </div>
      <footer> <pieComponent></pieComponent> </footer>
    </div>
  </template>
  
  <script>
  import cabezaComponent from '@/components/cabezaComponent.vue';
  import pieComponent from '@/components/pieComponent.vue';
  
  export default {
      components:{cabezaComponent, pieComponent}
  }
</script>

<style scoped>
.ContenedorPrincipal{
  display: flex;
  flex-direction: column;
  min-height: 100vh; /* Ocupa toda la altura de la ventana */
  margin: 0;
}
header {
  background: rgb(76, 78, 197);;
  color: white;
  text-align: center;
  padding: 10px 0;
}

.inicioContent {
  flex: 1; /* Ajusta dinámicamente el tamaño del contenido */
  background: rgb(76, 78, 197);
  color: white;
  padding: 20px;
}

footer {
  background: rgb(76, 78, 197);
  color: white;
  text-align: center;
  padding: 10px 0;
}

#imagen {
  display: flex; /* Flexbox para alineación horizontal */
  align-items: center; /* Centrado vertical */
  position: absolute;
  right: 18em;
  top: 5.5em;
}

#info{
  max-width: 600px;
  position: relative;
  left: 28%;
  top: 4em;
}

/* Imagen de perfil */
.foto {
  width: 200px; /* Ancho de la foto */
  height: 200px; /* Alto de la foto */
  border-radius: 50%; /* Forma circular */
  object-fit: cover; /* Ajusta la imagen para que no se deforme */
  border: 3px solid rgb(76, 78, 197); /* Borde azul */
}

.titulo {
  font-size: 2.5em;
  font-weight: bold;
  color: white;
  margin-bottom: 10px;
  position: absolute;
  left: 6em;
  bottom: 6.5em;
}

/* Estilos del subtítulo */
.subtitulo {
  font-size: 1.5em;
  font-weight: 600;
  color: white;
  margin-bottom: 20px;
  position: relative;
  top: 0.8em;
}

/* Estilos de la descripción */
.descripcion {
  font-size: 1em;
  line-height: 1.6;
  border: 2px solid #3545a0;
  padding: 15px;
  border-radius: 10px;
  background-color: #f4f4f4;
  color: #34495e;
  box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
}

#divisoraInicio{
    margin-right: 125px;
}

strong{
  color:rgb(76, 78, 197);
}
</style>