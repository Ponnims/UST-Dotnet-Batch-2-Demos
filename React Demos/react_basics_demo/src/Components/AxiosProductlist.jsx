import axios from 'axios';
import React, { useEffect, useState } from 'react'

const AxiosProductlist = () => {

    // state to hold the products data
    const [products, setProducts] = useState([]);
    const[loading, setLoading] = useState(true);
    const[error, setError] = useState(null);

    useEffect(() => {
        const fetchProducts = async () => {
            try {
                const response = await axios.get("https://fakestoreapi.com/products");
                console.log(response.data);
                setProducts(response.data);
                setLoading(false);
            }
            catch (error) {
                // console.error("Error fetching products:", error);
                setError("  Failed to fetch products. Please try again later.");
                setLoading(false);
            }

        };
        fetchProducts();
    },
        []

    );

    if(loading){
        return <h2>Loading...</h2>
    }
  if(error){
    return <h2>Error: {error.message}</h2>
  }

    return (
        <div className="container mt-4">
            <h1 className='text-center mb-4'>Product List</h1>
            <div className="row">
                {products.map((product) => (
                    <div className="col-md-4 mb-4" key={product.id}>
                        <div className="card h-100 shadow">
                            <img src={product.image} className="card-img-top" alt={product.title} style={{ height: '200px', objectFit: 'contain' }} />
                            <div className="card-body">
                                <h5 className="card-title">{product.title}</h5>
                                <p className='card-text small'>{product.description.substring(0, 100)}...</p>
                                <h4 className="card-text text-success">${product.price}</h4>
                            </div>
                            <div className='card-footer border-0'>
                                <button className="btn btn-primary m-2">Buy Now</button>
                                <button className="btn btn-secondary m-2">Add to Cart</button>
                            </div>
                        </div>
                    </div>
                ))}
            </div>
        </div>
    )
}

export default AxiosProductlist
