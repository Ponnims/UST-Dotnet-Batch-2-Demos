import React, { useState } from 'react'

const UseStateDemo = () => {
 
    const[name,setName] = useState("Ponnieaswari") ;
    const[counter,setCounter] = useState(0) ;
    const[isLoggedIn,setIsLoggedIn] = useState(false) ;
    const[products,setProducts] = useState(["Laptop","Mobile","Tablet"]) ;   
    const[person,setPerson] = useState({name:"Ponnieaswari",age:24,city:"Chennai"}) ; 
    //const myname="";

  return (
    <div>
      <h1>1. UseState Demo....Sample</h1>
      <p>My name is : {name}</p>

      {/* <button onClick={()=> name="NewName"}>Change MyName</button> 
      it is not posssible to modify the state directly */}
      <button onClick={()=> setName("NewName")}>Change MyName</button>
      <hr/>
      <h1>2. Use State with Number</h1>
      <p>Counter value is : {counter}</p>
        <button onClick={()=> setCounter(counter+1)}>Increment</button>
        <button onClick={()=> setCounter(counter-1)}>Decrement</button>

        <hr/>
        <h1>3. Use State with Boolean</h1>
        <p>Is User Logged In : {isLoggedIn ? "Yes" : "No"}</p>
        <button onClick={()=> setIsLoggedIn(!isLoggedIn)}>Toggle Login State</button>

        <hr/>
        <h1>4. Use State with Array</h1>
        {/* <p>Products : {products.join(", ")}</p> */}
        <ul>
            {products.map((item,index) => (
                <li key={index}>{item}</li>
            ))}
        </ul>
        <button onClick={()=> setProducts([...products,"Smartwatch"])}>Add Product</button>

        <hr/>
        <h1>5. Use State with Object</h1>
        <p>Name : {person.name}</p>
        <p>Age : {person.age}</p>
        <p>City : {person.city}</p>

        <button onClick={()=> setPerson({...person,age:45})}>Update Age</button>
    </div>
  )
}

export default UseStateDemo
