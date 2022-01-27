//import { Component } from 'react'
//class Footer extends Component {

    import React from 'react'
    //The React module/library already has a predefined class called as Component.
    class Footer extends React.Component{
        constructor(props){
            console.log("Constructor")
            super(props)
            this.state={
                myitems: [],
                mydataisloaded: false
            }
        }
        componentWillMount(){
            console.log("ComponentWillMount")
        }
        componentDidMount(){
            console.log("componentDidMount")
            //axios(3rd), request(3rd), fetch(inbuilt), etc...
            fetch("https://jsonplaceholder.typicode.com/albums")
            .then((mydata)=>mydata.json())
            .then((myjson) => {
                this.setState({
                    myitems: myjson,
                    mydataisloaded: true
                })
            }).catch((err)=>{
                console.log(err)
            })
        }
        render(){
            console.log("render")
            const { myitems, mydataisloaded } = this.state
            if(!mydataisloaded) return <div>Data Not Available</div>
            return (
            <div>
                <div class="container">
                    <footer class="d-flex flex-wrap justify-content-between align-items-center py-3 my-4 border-top">
                        <p class="col-md-4 mb-0 text-muted">© 2021 Company, Inc</p>
    
                        <a href="/" class="col-md-4 d-flex align-items-center justify-content-center mb-3 mb-md-0 me-md-auto link-dark text-decoration-none">
                            <svg class="bi me-2" width="40" height="32"></svg>
                        </a>
    
                        <ul class="nav col-md-4 justify-content-end">
                            <li class="nav-item"><a href="#" class="nav-link px-2 text-muted">Home</a></li>
                            <li class="nav-item"><a href="#" class="nav-link px-2 text-muted">Features</a></li>
                            <li class="nav-item"><a href="#" class="nav-link px-2 text-muted">Pricing</a></li>
                            <li class="nav-item"><a href="#" class="nav-link px-2 text-muted">FAQs</a></li>
                            <li class="nav-item"><a href="#" class="nav-link px-2 text-muted">About</a></li>
                        </ul>
                    </footer>
                </div>
    
                <div class="container">
                {
                    myitems.map((myvariables)=>(
                        <p key={myvariables.id}>{myvariables.userId}, {myvariables.id}, {myvariables.title}</p>
                    ))
                }
                </div>
            </div>
        )
        }
    }
    
    export default Footer