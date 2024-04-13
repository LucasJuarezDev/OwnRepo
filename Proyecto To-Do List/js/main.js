const motor = document.getElementById('motor');
const boton = document.getElementById('btn');
const listador = document.querySelector('ul');
const vacio = document.getElementById('void')


boton.addEventListener('click', (e) =>{
        e.preventDefault();
        
        
        const texto = motor.value;
        
        if(texto != ""){
                const list = document.createElement("input");
                
                
                listador.appendChild(list);
                listador.appendChild(btn_delete(list));
                
        }
})

function btn_delete(list){ //list es pasado como parametro, entonces el btn_delete puede manipularlo a su antojo
        const borrar = document.createElement("button");
        borrar.textContent = "x";
        borrar.setAttribute("id", "btn"); //herencia de id al elemento de 'borrar'

        borrar.addEventListener('click', (e) =>{
                listador.removeChild(list);      
                listador.removeChild(borrar);
        })

        return borrar;
}
