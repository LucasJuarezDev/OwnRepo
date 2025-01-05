<template>
    <nav>
      <ul>
        <li><router-link to="/inicio">INICIO</router-link></li>
        <li><router-link to="/flota">NUESTRA FLOTA</router-link></li>
        <li><router-link to="/contactanos">CONTÁCTANOS</router-link></li>
        <li><router-link to="/about">ACERCA DE</router-link></li>
      </ul>
    </nav>
  </template>
  
  <script>
  export default {
      data(){
          return{
  
          }
      }
  }
  </script>
  
  <style scoped>
  nav {
    background: slateblue; /* Fondo igual al de la página */
    padding: 14px 0;
    margin-bottom: 20px; /* Espaciado opcional entre nav y contenido */
  }
  
  ul {
    list-style-type: none;
    text-align: center;
    margin: 0;
    
  }
  
  li {
    display: inline-block;
    margin: 0 25px;
  }
  
  a {
    color: white;
    text-decoration: none;
    font-family: "Open Sans", sans-serif;
    font-weight: 800;
    font-size: 1em;
    padding: 6px 12px;
    border-radius: 10px;
    transition: background-color 0.3s ease;
  }
  
  .router-link-active {
    background: white;
    color: slateblue;
  }
  
  /* Estilos para hover en enlaces */
  a:hover {
    background-color: rgba(255, 255, 255, 0.2);
    color: white;
  }
  
  </style>