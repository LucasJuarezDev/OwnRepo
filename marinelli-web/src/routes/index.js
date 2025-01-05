import Vue from "vue";
import VueRouter from "vue-router";
/////////  COMPONENTES ////////
import aboutComponent from "@/views/aboutComponent.vue";
import contactanosComponent from "@/views/contactanosComponent.vue";
import flotaComponent from "@/views/flotaComponent.vue";
import somosComponent from "@/views/somosComponent.vue";

Vue.use(VueRouter);

const routes = 
[
    {path:'/about', component:aboutComponent},
    {path:'/contactanos', component:contactanosComponent},
    {path:'/flota', component:flotaComponent},
    {path:'/inicio', component:somosComponent},
    {path:'/', redirect:'/inicio'},
];

const router = new VueRouter({
    routes,
});

export default router;