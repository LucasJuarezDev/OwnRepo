<template>
    <div class="ContenedorPrincipal">
      <header><cabezaComponent></cabezaComponent> </header>
      <div class="inicioContent">
        <h1 id="tituloSeccion">Mis Proyectos realizados</h1>
        <hr>
        <h2 id="subtituloSeccion">(clickear en la imagen para dirigirse al repo)</h2>
        <div class="contentProyectos">
          <div class="proyectos" @mouseover="banderaUno = true" @mouseleave="banderaUno = false">
            <h1 :class="banderaUno ? 'tituloCapitalize' : 'titulo'">Software De Escritorio Para Gestion Comercial</h1>
            <a href="https://github.com/LucasJuarezDev/OwnRepo/tree/47641b3f4b4f493b41d857e1206b85c7acee1687/SistemaGestion" target="blank"> <img v-if="banderaUno" src="../assets/proyect-images/lcsystem.png" alt="screenshot p1"> </a>
            <p v-if="banderaUno">
              Este proyecto es una idea personal que tuve al hablar con distintos
              clientes trabajando para una distribuidora de alimentos, estudiando y recopilando
              datos llegue a la conclusión de llevarlo a la realidad, Primero empecé con
              el modelo de domino, luego fui del backend hasta su frontend. El
              proyecto en si es un sistema de ventas con control de stock incluido. Esta
              realizado con tecnología de C# .NET Framework, ADO.NET y SQL Server.
              La idea principal es comerciarla con los clientes que estén interesados en
              la idea. Esta hecha para el uso profesional, permite realizar ventas, ver el
              historial de ventas por día, semana o meses, exportar estos datos a un
              Excel para llevarlos claros. Esta aplicación la realice con la idea que sea
              escalable y si es necesario agregarle mas tópicos
            </p>
          </div>
          <div class="proyectos" @mouseover="banderaDos = true" @mouseleave="banderaDos = false">
            <h1 :class="banderaDos ? 'tituloCapitalize' : 'titulo'">Proyecto de Facultad (Segundo Año)</h1>
            <a href="https://github.com/LucasJuarezDev/Laboratorio2_Proyecto" target="blank"> <img v-if="banderaDos" src="../assets/proyect-images/proyectoFacu.png" alt="screenshot p2"> </a>     
            <p v-if="banderaDos">
              Este proyecto fue la evaluación final de la materia Laboratorio II de la
              Tecnicatura en Programación. En esta materia vimos programación orientada a objetos, cómo
              diseñar clases, cómo salir del pensamiento de programación estructurada y
              el uso de archivos. Este proyecto fue en grupo; en total, fuimos tres
              integrantes. La idea surgió cuando un compañero planteo una problemática
              que su pareja tenia en su emprendimiento. Usaba mucho Excel y papel
              para llevar el stock y las ventas en su local de ropa, entonces ideamos un
              plan para desarrollar un programa que le facilitara las tareas planteadas
              anteriormente. La idea se puso en marcha y en conjunto los tres lo
              sacamos adelante tras muchos traspiés, pero siempre pudimos resolverlos
              entendiéndonos y hablando. A medida que pasaba el tiempo, fuimos
              aprendiendo a trabajar en equipo, a usar GitHub colaborativamente.
              Finalmente, el proyecto fue exitosamente aprobado.

            </p>
          </div>
          <div class="proyectos" @mouseover="banderaTres = true" @mouseleave="banderaTres = false">
            <h1 :class="banderaTres ? 'tituloCapitalize' : 'titulo'">Diseño Web Para Fletes Marinelli (Logistica y Fletes)</h1>
            <a href="https://github.com/LucasJuarezDev/OwnRepo/tree/main/marinelli-web" target="blank"> <img v-if="banderaTres" src="../assets/proyect-images/proyectoWeb.png" alt="screenshot p3"> </a>
            <p v-if="banderaTres">
              Esta web la inicie con la idea de sumergirme en el mundo del frontend, haciendo practica 
              principalmente de Vue.js 2, un framework de javascript basado en templates. Puse en practica 
              mis habilidades en CSS y HTML también. El proposito de la página web es ayudar con mas publicidad 
              a la Pyme de mi empleador, orientado al mundo de la logistica. Tambien tiene implementado un sistema 
              donde el cliente pueda mandar email para consultar sobre la cotizacion de un trabajo, y esta hecho con 
              conocimiento de Node.js (Express.js y Nodemailer). El diseño lo fui consultando con mi empleador y quedo 
              a gusto con el resultado. Principalmente me resulto un desafio el tema de Node, y con este proyecto lo fui 
              aprendiendo a la par de como avanzaba.
            </p>
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
          banderaUno: false,
          banderaDos: false,
          banderaTres: false,
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
  color: white;
  padding: 20px;
}

footer {
  background: rgb(76, 78, 197);
  color: white;
  text-align: center;
  padding: 10px 0;
}

.contentProyectos{
  display: inline-block;
  width: 50%;
  max-width: 1000px;
  position: relative;
  left: 21rem;
}

.proyectos{
  background-color: white;
  color: rgb(76, 78, 197);
  border-radius: 20px;
  box-shadow: 0 4px 8px rgba(0, 1, 0, 2);
  padding: 5px;
  margin-bottom: 20px;
  transition: transform 0.3s ease, box-shadow 0.3s ease;
}

.proyectos:hover{
  transform: scale(1.01); /* Incrementa el tamaño ligeramente */
}

.titulo{
  text-align: center;
  text-transform: uppercase;
}

.tituloCapitalize{
  text-align: center;
  text-transform: capitalize;
}

p{
  text-transform: capitalize;
  text-align: center;
  font-size: 1rem;
}

img{
  display: block;
  margin: 0 auto;
  padding: 5px;
  width: 300px;
  height: 200px;
  object-fit: cover;
  border-radius: 20px;
  box-shadow: 0 4px 8px rgba(0, 1, 0, 2);
}

#tituloSeccion{
  text-align: center;
  text-transform: uppercase;
  position: relative;
  bottom: 1.3em;
  font-size: 3em;
}

hr{
  margin: 0 100px;
  position: relative;
  bottom: 5.5em;
}

#subtituloSeccion{
  text-align: center;
  font-style: italic;
  font-size: 1em;
  position: absolute;
  top: 27%;
  right: 38%;
}
</style>