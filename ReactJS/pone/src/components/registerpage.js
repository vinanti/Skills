import React from "react";
class Registerpage extends React.Component {
    render() {
        return (
            <div>
                <form>
                    <div className="mb-3">
                        <label for="exampleInputName1" className="form-label">User Name</label>
                        <input type="text" className="form-control" id="exampleInputName1"></input>
                    </div>
                    <div className="mb-3">
                        <label for="exampleInputEmail1" className="form-label">Email address</label>
                        <input type="email" className="form-control" id="exampleInputEmail1" aria-describedby="emailHelp"></input>
                        <div id="emailHelp" className="form-text">We'll never share your email with anyone else.</div>
                    </div>
                    <div className="mb-3">
                        <label for="exampleInputPassword1" className="form-label">Password</label>
                        <input type="password" className="form-control" id="exampleInputPassword1"></input>
                    </div>
                    <div className="mb-3">
                        <label for="exampleInputPassword2" className="form-label">Confirm Password</label>
                        <input type="password" className="form-control" id="exampleInputPassword2"></input>
                    </div>
                    <div className="mb-3 form-check">
                        <input type="checkbox" className="form-check-input" id="exampleCheck1"></input>
                        <label className="form-check-label" for="exampleCheck1">Check me out</label>
                    </div>
                    <button type="submit" className="btn btn-primary">Submit</button>
                </form>
            </div>
        )
    }
}

export default Registerpage