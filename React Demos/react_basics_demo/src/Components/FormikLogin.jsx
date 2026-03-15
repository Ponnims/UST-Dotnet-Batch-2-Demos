import { ErrorMessage, Field, Form, Formik } from 'formik'
import * as Yup from "yup"
import React from 'react'

const FormikLogin = () => {

    /*
    Yup validation schema defines validation rules
    for each field in the form.

    Yup.object() creates a validation schema object.
    */

    const validationSchema = Yup.object({

        email: Yup.string()
            .email("Invalid Email Format")   // email must be valid
            .required("Email is Required"),  // email cannot be empty

        password: Yup.string()
            .min(6, "Password must be atleast 6 characters") // minimum length rule
            .required("Password is mandatory") // password cannot be empty
    });

    return (

        <div className='container mt-5'>

            {/* Bootstrap grid used to center the form */}

            <div className="row justify-content-center">

                <div className="col-md-5">

                    {/* Bootstrap card used for better UI */}

                    <div className="card shadow-lg">

                        <div className="card-body">

                            <h3 className="text-center mb-4">LOGIN</h3>

                            {/* 
                            Formik component manages:

                            - form state (values)
                            - validation
                            - form submission

                            Props used:

                            initialValues → initial form data
                            validationSchema → Yup validation rules
                            onSubmit → executed when form submits successfully
                            */}

                            <Formik
                                initialValues={{ email: "", password: "" }}
                                validationSchema={validationSchema}

                                onSubmit={(values) => {
                                    console.log(values);
                                    alert("Login Successful");
                                }}
                            >

                                {({ errors, touched }) => (

                                    /*
                                    errors → contains validation errors
                                    touched → tracks whether user interacted with field

                                    We use them to conditionally apply Bootstrap error styles.
                                    */

                                    <Form>

                                        {/* EMAIL FIELD */}

                                        <div className="mb-3">

                                            <label className='form-label'>Email</label>

                                            {/* 
                                            Field component replaces normal HTML input.

                                            name="email"
                                            must match the property inside initialValues.

                                            The className condition checks:

                                            If email has validation error AND
                                            the field is already touched,
                                            then Bootstrap class "is-invalid" is applied.
                                            */}

                                            <Field
                                                type="email"
                                                name="email"
                                                placeholder="Enter email"
                                                className={`form-control ${errors.email && touched.email ? "is-invalid" : ""}`}
                                            />

                                            {/* 
                                            ErrorMessage component automatically displays
                                            validation messages for the specified field.

                                            name="email" → must match field name

                                            component="div" → error wrapped in div

                                            className="invalid-feedback"
                                            Bootstrap class that shows error text in red
                                            below the input field.
                                            */}

                                            <ErrorMessage
                                                name='email'
                                                component="div"
                                                className='invalid-feedback'
                                            />

                                        </div>


                                        {/* PASSWORD FIELD */}

                                        <div className="mb-3">

                                            <label className='form-label'>Password</label>

                                            <Field
                                                type="password"
                                                name="password"
                                                placeholder="Enter password"
                                                className={`form-control ${errors.password && touched.password ? "is-invalid" : ""}`}
                                            />

                                            <ErrorMessage
                                                name='password'
                                                component="div"
                                                className='invalid-feedback'
                                            />

                                        </div>


                                        {/* LOGIN BUTTON */}

                                        <div className="d-grid">

                                            {/* 
                                            type="submit" automatically triggers Formik onSubmit
                                            We do NOT need to manually call onSubmit.
                                            */}

                                            <button type="submit" className='btn btn-primary'>
                                                Login
                                            </button>

                                        </div>

                                    </Form>

                                )}

                            </Formik>

                        </div>

                    </div>

                </div>

            </div>

        </div>

    )
}

export default FormikLogin