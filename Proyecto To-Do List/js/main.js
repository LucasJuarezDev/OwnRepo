const motor = document.getElementById('motor');
const boton = document.getElementById('btn');
const listador = document.querySelector('ul');


boton.addEventListener('click', (e) =>{
        let cont = 0;
        const vacio = document.querySelector('.void')
        e.preventDefault();
        
        
        const texto = motor.value;
        
        if(texto != ""){
                vacio.remove();
                const agregar = document.createElement("button");
                const list = document.createElement("input");
                agregar.textContent = "+" ;
                list.setAttribute("class", "motor");
                agregar.setAttribute("class", "btn_agregar")
                
                
                listador.appendChild(list);
                listador.appendChild(btn_new(list, agregar));
                listador.appendChild(btn_delete(list, agregar));
                
        }
})

function btn_delete(list, agregar){ //list es pasado como parametro, entonces el btn_delete puede manipularlo a su antojo
        const borrar = document.createElement("button");
        borrar.textContent = "x";
        borrar.setAttribute("class", "btn_borrar"); //herencia de id al elemento de 'borrar'

        borrar.addEventListener('click', (e) =>{
                listador.removeChild(list);      
                listador.removeChild(borrar);
                listador.removeChild(agregar);
        })

        return borrar;
}

 function btn_new(list, agregar){
        agregar.addEventListener('click', (e) =>{
                listador.appendChild(list);
                listador.appendChild(agregar);
                       
         })
        return agregar;
 }
