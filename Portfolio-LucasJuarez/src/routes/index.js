import Vue from "vue";
import VueRouter from "vue-router";
///// COMPONENTES ////
import contactoComponent from "@/views/contactoComponent.vue";
import inicioComponent from "@/views/inicioComponent.vue";
import proyectosComponent from "@/views/proyectosComponent.vue";
import skillsComponent from "@/views/skillsComponent.vue";

Vue.use(VueRouter);

const routes = 
[
    {path:'/inicio', component:inicioComponent},
    {path:'/portfolio', component:proyectosComponent},
    {path:'/contacto', component:contactoComponent},
    {path:'/habilidades', component:skillsComponent},
    {path:'/', redirect:'/inicio'},
];

const router = new VueRouter({
    routes,
});

export default router;