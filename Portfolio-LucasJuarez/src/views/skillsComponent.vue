<template>
    <div class="contenedorPrincipal">
      <header><cabezaComponent></cabezaComponent> </header>
      <div class="inicioContent">
        <div class="contenedorSkill">
          <div class="skill" @mouseover="csharpOcultar = true" @mouseleave="csharpOcultar = false"> 
            <h1 v-if="!csharpOcultar" class="texto">ACÁ</h1>
            <img v-if="csharpOcultar" src="../assets/skill-images/CSHARP.png" alt="csharp" id="ajustes-uno">
          </div>
          <div class="skill" @mouseover="cplusOcultar = true" @mouseleave="cplusOcultar = false">
            <h1 v-if="!cplusOcultar" class="texto">SE</h1>
            <img  v-if="cplusOcultar" src="../assets/skill-images/CPLUS.png" alt="c++">
          </div>
          <div class="skill" @mouseover="jsOcultar = true" @mouseleave="jsOcultar = false">
            <h1 v-if="!jsOcultar" class="texto">PUEDEN</h1>
            <img v-if="jsOcultar" src="../assets/skill-images/JAVASCRIPT.png" alt="js">
          </div>
          <div class="skill" @mouseover="sqlOcultar = true" @mouseleave="sqlOcultar = false">
            <h1 v-if="!sqlOcultar" class="texto">VER</h1>
            <img v-if="sqlOcultar" src="../assets/skill-images/SQLserver.png" alt="sql">
          </div>
          <div class="skill" @mouseover="htmlOcultar = true" @mouseleave="htmlOcultar = false">
            <h1 v-if="!htmlOcultar" class="texto">MIS</h1>
            <img v-if="htmlOcultar" src="../assets/skill-images/HTML.png" alt="html" id="ajustes-uno">
          </div>
          <div class="skill" @mouseover="cssOcultar = true" @mouseleave="cssOcultar = false">
            <h1 v-if="!cssOcultar" class="texto">HABILIDADES</h1>
            <img v-if="cssOcultar" src="../assets/skill-images/CSS.png" alt="css">
          </div>
          <div class="skill" @mouseover="gitOcultar = true" @mouseleave="gitOcultar = false">
            <h1 v-if="!gitOcultar" class="texto">Y</h1>
            <img v-if="gitOcultar" src="../assets/skill-images/GITHUB.png" alt="git" id="ajustes-uno">
          </div>
          <div class="skill" @mouseover="vueOcultar = true" @mouseleave="vueOcultar = false">
            <h1 v-if="!vueOcultar" class="texto">ACÁ</h1>
            <img v-if="vueOcultar" src="../assets/skill-images/VUEJS.png" alt="vue" id="ajustes-dos">
          </div>
          <div class="skill" @mouseover="nodeOcultar = true" @mouseleave="nodeOcultar = false">
            <h1 v-if="!nodeOcultar" class="texto">TAMBIÉN ;)</h1>
            <img v-if="nodeOcultar" src="../assets/skill-images/NODEJS.png" alt="node" id="ajustes-dos">
          </div>
        </div>
      </div>
      <footer> <pieComponent></pieComponent> </footer>
    </div>
  </template>
  
  <script>
  import cabezaComponent from '@/components/cabezaComponent.vue';
  import pieComponent from '@/components/pieComponent.vue';
  
  export default {
      components:{cabezaComponent, pieComponent},
      data(){
        return{
          csharpOcultar : false,
          cplusOcultar : false,
          jsOcultar : false,
          sqlOcultar : false,
          htmlOcultar : false,
          cssOcultar : false,
          gitOcultar : false,
          vueOcultar : false,
          nodeOcultar : false,
        }
      },
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
  background: rgb(76, 78, 197);
  color: white;
  text-align: center;
  padding: 10px 0;
}

.inicioContent {
  flex: 1; /* Ajusta dinámicamente el tamaño del contenido */
  background: rgb(76, 78, 197);
  background: radial-gradient(circle, rgba(104,119,166,1) 0%, rgb(76, 78, 197) 80%);
  color: white;
  padding: 20px;
}

footer {
  background: rgb(76, 78, 197);
  color: white;
  text-align: center;
  padding: 10px 0;
}

.contenedorSkill{
  display: grid;
  grid-template-columns: repeat(3, 1fr);
  width: 50%;
  max-width: 700px;
  position: relative;
  left: 20em;
}

.skill{
  background: rgb(76, 78, 197);
  transition: background-color 0.3s ease-in-out;
  cursor: pointer;
  position: relative;
  color: rgb(76, 78, 197);
  border-radius: 10px;
  margin-bottom: 3em;
  margin-right: 2em;
  box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
  display: flex;
  align-items: center;
  justify-content: center;
  height: 120px;
}

.skill:hover{
  background-color: white;
}

.skill img{
  width: 80px;
  height: auto; 
  object-fit: contain; /* La imagen se ajustará al contenedor sin distorsionarse */
}

.texto{
  color: white; /* Texto blanco sobre fondo azul */
  font-size: 1.2em;
  text-transform: uppercase;
  font-family: "Open Sans", sans-serif;
  position: absolute; 
  transition: opacity 0.3s ease-in-out; 
}

/*AJUSTE PERSONAL DE IMAGENES*/

#ajustes-uno{
  width: 100px;
  height: 135px;
  object-fit: cover;
}

#ajustes-dos{
  width: 90px;
  height: 100px;
  object-fit: cover;
}
</style>