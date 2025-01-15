import React, { useEffect, useState } from 'react';

const Test = () => {
    // State to store characters data
    const [characters, setCharacters] = useState([]);
    const [loading, setLoading] = useState(true);
    const [error, setError] = useState(null);

    useEffect(() => {
        // Fetch data from the backend
        const fetchCharacters = async () => {
            try {
                const response = await fetch('/allcharacters');
                if (!response.ok) {
                    throw new Error('Failed to fetch data');
                }
                const data = await response.json();
                setCharacters(data); // Update state with fetched data
            } catch (err) {
                setError(err.message);
            } finally {
                setLoading(false);
            }
        };

        fetchCharacters();
    }, []);

    // Render loading, error, or character list
    if (loading) {
        return <div>Loading...</div>;
    }

    if (error) {
        return <div>Error: {error}</div>;
    }

    return (
        <div>
            <h1>All Characters</h1>
            <ul>
                {characters.map((character) => (
                    <li key={character.id}>
                        <h2>{character.name}</h2>
                        <p>{character.description}</p>
                    </li>
                ))}
            </ul>
        </div>
    );
};

export default Test;
