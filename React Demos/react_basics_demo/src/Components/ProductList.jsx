import React from 'react'

//const ProductList = ({ brandname, price,showmessage }) => { // using props using destructuring
const ProductList = (props) => {
     const Title="My Favorite Product"
     console.log(props);
    return (

        <div className="card" style={{width: '18rem'}}>
            <img src="https://picsum.photos/200/300" class="card-img-top" alt="..." />
            <div className="card-body">
                <h5>{Title}</h5>
                <p>Brand is : {props.brandname} </p>
                <p>Price is : {props.price}</p>
                 {/* <p>Brand is : {brandname} </p>
                <p>Price is : {price}</p> */}
                <a href="#" className="btn btn-primary">Go somewhere</a>
                <button onClick ={props.showmessage}>Click me</button>
            </div>
        </div>
    )
}

export default ProductList
