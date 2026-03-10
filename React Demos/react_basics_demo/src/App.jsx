import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
// import './App.css'
import Sampletocheck from './Components/Sampletocheck'
import Header from './Components/Header'
import Footer from './Components/Footer'
import ProductList from './Components/ProductList'

function App() {
 
  function btnclck()
  {
    alert("Button is clicked, saying Hello from Parent")
  }

  return (
    <>
     {/* <Sampletocheck /> */}
     <Header />
     <ProductList brandname="Lenova" price={545456}/>
     <ProductList brandname="HP" price={78787979}/>
     <ProductList brandname="Apple" price={34456767} showmessage ={btnclck}/>
     <Footer />
   </>
  )
}

export default App
