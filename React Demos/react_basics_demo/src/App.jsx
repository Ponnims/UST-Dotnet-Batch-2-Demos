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
import AxiosUser from './Components/AxiosUser'
import AxiosProductlist from './Components/AxiosProductlist'
import { BrowserRouter, Routes, Route } from 'react-router-dom'
import Home from './Home'
import ABout from './ABout'
import Contact from './Contact'

function App() {

  const btnclck = () => {
    alert("Hello from Parent!");
  };

  return (
    <>
      <BrowserRouter>
        <Header />
        <Routes>
          <Route path="/" element={<Home />} />
          <Route path="/about" element={<ABout />} />
          <Route path="/contact" element={<Contact />} />
          <Route path="/login" element={<FormikLogin />} />
          <Route path="/users" element={<AxiosUser />} />
          <Route path="/products" element={<AxiosProductlist />} />

        </Routes>
        <Footer />
      </BrowserRouter>
    </>
  )
}

export default App
