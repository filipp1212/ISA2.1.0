function sayHello(name) {
    return function(){
        console.log('howdy'+ name);
    }
}

let bob = sayHello(bob)

bob();