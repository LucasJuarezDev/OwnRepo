<template>
<div class="contp">
    <nav>
        <ul>
            <li> <router-link to="/inicio">PRESENTACION</router-link> </li>
            <li> <router-link to="/habilidades">MIS HABILIDADES</router-link> </li>
            <li> <router-link to="/portfolio">PROYECTOS</router-link> </li>
            <li> <router-link to="/contacto">CONTACTO</router-link> </li>
        </ul>
    </nav>
</div>
</template>

<script>
export default {

}
</script>

<style scoped>
.contp{
  display: flex;
  flex-direction: column;
}
nav {
  /* Fondo igual al de la página */
  padding: 10px 0;
  background: rgb(76, 78, 197);
  margin-bottom: 20px; /* Espaciado opcional entre nav y contenido */
}

ul {
  list-style-type: none;
  text-align: center;
  margin: 0;
}

li {
  display: inline-block;
  margin: 0 35px;
}

a {
  color: white;
  text-decoration: none;
  font-size: 1em;
  font-family: "Open Sans", sans-serif;
  font-weight: 800;
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