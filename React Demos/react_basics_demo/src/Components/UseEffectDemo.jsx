import React, { use, useEffect, useState } from 'react'

const UseEffectDemo = () => {
    // Syntax of useEffect
    // useEffect(
    // callback function, dependency array
    // );

    const [count, setCount] = useState(0);

    // useEffect(()=>{
    //     console.log("Component is Loaded");
    // },[]) // it will call only once when the component is mounted

   

    // useEffect(() => {
    //     console.log("Count value is updated : ", count);
    // }, [count]); // it will call whenever the count value is updated

    return (
        <div style={{ padding: "20Px" }}>
            <h1>UseEffect Demo....</h1>

            <h2>Counter Value : {count}</h2>

            <button class="btn btn-primary" onClick={() => setCount(count + 1)}>Increment</button>

        </div>
    )
}

export default UseEffectDemo
