import React from 'react'
import { Link } from 'react-router-dom'

const Header = () => {
  return (
//    <nav class="navbar navbar-expand-lg bg-body-tertiary">
<nav class="navbar  navbar-expand-lg border-bottom border-body bg-primary" data-bs-theme="dark">
  <div class="container-fluid">
    <a class="navbar-brand" href="#">My Sample App</a>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarSupportedContent">
      <ul class="navbar-nav me-auto mb-2 mb-lg-0">
        <li class="nav-item">
          {/* <a class="nav-link active" aria-current="page" href="/">Home</a> */}
          {/* if you use hyperlinks it will cause a full page reload
          so we should use LINK */}

          <Link className='nav-link active' aria-current="page" to="/">Home</Link>
        </li>
        <li class="nav-item">
          <Link className='nav-link' to="/about">About</Link>
        </li>
        <li class="nav-item">
          <Link className='nav-link' to="/contact">Contact</Link>
        </li>
        <li class="nav-item">
          <Link className='nav-link' to="/products">Products</Link>
        </li>
        
        <li class="nav-item">
          <Link className='nav-link' to="/users">Users</Link  >
        </li>
       
      </ul>

      <ul className='navbar-nav ms-auto'>
        <li class="nav-item">
          <Link className='nav-link' to="/login">
          <i class="bi bi-person-badge"></i>
          Login</Link>
        </li>
      </ul>
     
    </div>
  </div>
</nav>
  )
}

export default Header
