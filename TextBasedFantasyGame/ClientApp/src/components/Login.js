import React, { useState } from "react";
import axios from "axios";
import { useNavigate } from "react-router-dom";
import "../custom.css"; // Import the CSS file

const LoginPage = () => {
    const [email, setEmail] = useState("");
    const [password, setPassword] = useState("");
    const [errorMessage, setErrorMessage] = useState("");
    const navigate = useNavigate();

    const handleLogin = async (e) => {
        e.preventDefault();

        try {
            const response = await axios.post("/api/user/login", {
                email,
                password,
            });            
            navigate("/home"); // Redirect to home or dashboard page
        } catch (error) {
            setErrorMessage(
                error.response?.data || "Failed to log in. Please try again."
            );
        }
    };

    return (
        <div className="login-container">
            <div className="login-card">
                <h2>Login</h2>
                <form onSubmit={handleLogin} className="login-form">
                    <div className="input-group">
                        <label>Email</label>
                        <input
                            type="email"
                            value={email}
                            onChange={(e) => setEmail(e.target.value)}
                            placeholder="Enter your email"
                            required
                        />
                    </div>
                    <div className="input-group">
                        <label>Password</label>
                        <input
                            type="password"
                            value={password}
                            onChange={(e) => setPassword(e.target.value)}
                            placeholder="Enter your password"
                            required
                        />
                    </div>
                    {errorMessage && (
                        <p className="error-message">{errorMessage}</p>
                    )}
                    <button type="submit" className="login-button">
                        Login
                    </button>
                </form>
                <p>
                    Don't have an account?{" "}
                    <a
                        href="/signup"
                        onClick={() => navigate("/signup")}
                        className="signup-link"
                    >
                        Sign up
                    </a>
                </p>
            </div>
        </div>
    );
};

export default LoginPage;
