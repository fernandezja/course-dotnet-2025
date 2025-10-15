   var demo = "demo";
       var demo2 = 2;
       var demo3 = true;
       var demo4 = null;
       var demo5; // undefined

       let demo6 = "demo6";
       const demo7 = "demo7";

       let demo8 = {}; // objeto vacio

       let demo9 = {
            nombre: "Juan", 
            edad: 30
        }; // objeto con propiedades

       //alert(demo3);

       var tituloh1 = window.document.getElementById("tituloh1");
        //tituloh1.innerText = 'Hello World! v4';

        

        tituloh1.addEventListener('click', cambiarTitulo);
        tituloh1.addEventListener('mousemove', cambiarTitulo);

        var index = 0;
        
        function cambiarTitulo(){
            index++;
            tituloh1.innerText = 'Hello World! v'+  index;

        }

let formContacto = document.getElementById("formContacto");
formContacto.addEventListener('submit', validarFormulario);

function validarFormulario(event){
    event.preventDefault(); //cancela el evento "submit"
    
    //Validar campos
    let nombre = document.getElementById("nombre").value;
    let email = document.getElementById("email").value;
    let mensaje = document.getElementById("mensaje").value;

    if(nombre === "" || email === "" || mensaje === ""){
        alert("Por favor, completa todos los campos.");
        return;
    }

    alert("Formulario enviado");

    formContacto.style.display = "none";
}
