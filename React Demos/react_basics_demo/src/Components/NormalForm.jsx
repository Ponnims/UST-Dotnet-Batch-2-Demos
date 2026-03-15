import React, { useState } from 'react'

const NormalLoginForm = () => {

    const[values,setValues] = useState(
        {
            email:"",
            password:""
        }
    )

const handleSubmit =(e)=>
{
    e.preventDefault();
    console.log(values);
    alert("Form Submitted Successfully")
}

const handleChange =(e)=>
{
   const{name,value}= e.target;
   setValues({
    ...values,
    [name]:value
   });
}

    return (
        <div className='container mt-5'>
            <div className='row jsutify-content-center'>
                <div className="col-md-5">
                    <div className="card shadow-lg">
                        <div className="card-body">
                            <h3 className='text-center mb-4'>Login </h3>

                            <form onSubmit={handleSubmit}>
                                <lable className="form-label">Email </lable>
                                <input type="email" name="email" className='form-control' value={values.email} placeholder='Enetr Email' onChange={handleChange} />
                                <label className="form-label">Password</label>
                                <input type='password' name='password' className='form-control' value={values.password} placeholder='Enter Password'  onChange={handleChange}/>
                                <div className='d-grid'>
                                <button className='btn btn-primary' type='submit'>Login</button>
                                </div>
                            </form>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    )
}

export default NormalLoginForm
