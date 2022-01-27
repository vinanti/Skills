import React from 'react'
//import {Component} from 'react'

class Login extends React.Component{
    constructor(){
        super()
        this.state ={
            myvalue1: '',
            myvalue2: '',
            mycomma: ''
        }
    }
    mytrigger1 = (event) =>{
        this.setState({myvalue1: event.target.value})
    }
    mytrigger2 = (event) =>{
        const abc = event.target.value
        if(abc === "Anand")
        {
            console.log("Last Name is something diff then Anand")
        }
        this.setState({myvalue2: event.target.value})
    }

    render(){
        return(
            <div>
                <form>
                    <input type="text" 
                    placeholder="Enter your First Name"
                    onChange={this.mytrigger1}
                    />
                    <input type="text" 
                    placeholder="Enter your Last Name"
                    onChange={this.mytrigger2}
                    />
                </form>
                <p>{this.state.myvalue1} {this.state.myvalue2}</p>
            </div>
        )
    }
}

export default Login