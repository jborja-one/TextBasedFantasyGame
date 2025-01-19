import React, { useState } from "react";
import axios from "axios";
import { useNavigate } from "react-router-dom";
import "../custom.css"; // Import the CSS file

const SignupPage = () => {
    const [email, setEmail] = useState("");
    const [password, setPassword] = useState("");
    const [errorMessage, setErrorMessage] = useState("");
    const [successMessage, setSuccessMessage] = useState("");
    const navigate = useNavigate();

    const handleSignup = async (e) => {
        e.preventDefault();

        try {
            const response = await axios.post("/api/user/signup", {
                email,
                password,
            });
            setSuccessMessage(response.data); // Signup successful
            setErrorMessage("");
            setTimeout(() => {
                navigate("/login"); // Redirect to login page after signup
            }, 2000);
        } catch (error) {
            setErrorMessage(
                error.response?.data || "Failed to sign up. Please try again."
            );
            setSuccessMessage("");
        }
    };

    return (
        <div className="signup-container">
            <div className="signup-card">
                <h2>Sign Up</h2>
                <form onSubmit={handleSignup} className="signup-form">
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
                    {successMessage && (
                        <p className="success-message">{successMessage}</p>
                    )}
                    <button type="submit" className="signup-button">
                        Sign Up
                    </button>
                </form>
                <p>
                    Already have an account?{" "}
                    <a
                        href="/login"
                        onClick={() => navigate("/login")}
                        className="login-link"
                    >
                        Log in
                    </a>
                </p>
            </div>
        </div>
    );
};

export default SignupPage;
