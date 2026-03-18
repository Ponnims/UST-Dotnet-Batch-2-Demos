import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
// import './App.css'
import Sampletocheck from './Components/Sampletocheck'
import Header from './Components/Header'
import Footer from './Components/Footer'
import ProductList from './Components/ProductList'
import UseStateDemo from './Components/UseStateDemo'
import UseEffectDemo from './Components/UseEffectDemo'
import NormalLoginForm from './Components/NormalForm'
import FormikLogin from './Components/FormikLogin'
import TraineesList from './Components/TraineesList'

function App() {
 
  const btnclck = () => {
    alert("Hello from Parent!");
  };

  return (
    <>
     {/* <Sampletocheck /> */}
     <Header />
     {/* <ProductList brandname="Lenova" price={545456}/>
     <ProductList brandname="HP" price={78787979}/>
     <ProductList brandname="Apple" price={34456767} showmessage ={btnclck}/> */}

     {/* <UseStateDemo  /> */}
     {/* <UseEffectDemo/> */}
     {/* <NormalLoginForm/> */}

     {/* <FormikLogin /> */}
     <TraineesList  />
    
     <Footer />
   </>
  )
}

export default App
