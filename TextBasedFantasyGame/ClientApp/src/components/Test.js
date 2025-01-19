import React, { useEffect, useState } from 'react';

const Test = () => {
    // State to store jobs data
    const [jobs, setJobs] = useState([]);
    const [loading, setLoading] = useState(true);
    const [error, setError] = useState(null);

    useEffect(() => {
        // Fetch data from the backend
        const fetchCharacters = async () => {
            try {
                const response = await fetch('api/jobs');
                console.log(`Data ${response}`);
                
                if (!response.ok) {
                    throw new Error('Failed to fetch data');
                }
                const data = await response.json();
                console.log(data);
                setJobs(data); // Update state with fetched data
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
                {jobs.map((job) => (
                    <li key={job.jobId}>
                        <h2>{job.name}</h2>
                        <p>{job.description}</p>                        
                        {job.actions && job.actions.length > 0 && (
                            <div>
                                <h3>Actions</h3>
                                <ul>
                                    {job.actions.map((action) => (
                                        <li key={action.id || action.name}>
                                            <div>
                                                <strong>{action.name}</strong>
                                                <p>Description: {action.description}</p>
                                                <p>Cooldown: {action.cooldown}</p>
                                                <p>Potency: {action.potency}</p>
                                                <p>Required Level: {action.requiredLevel}</p>
                                            </div>
                                        </li>
                                        
                                    ))}
                                </ul>
                            </div>
                        )}
                        {job.abilities && job.abilities.length > 0 && (
                            <div>
                                <h3>Abilities</h3>
                                <ul>
                                    {job.abilities.map((ability) => (
                                        <li key={ability.id || ability.name}>
                                            <div>
                                                <strong>{ability.name}</strong>
                                                <p>Description: {ability.description}</p>
                                                <p>Cooldown: {ability.cooldown}</p>                                                
                                                <p>Required Level: {ability.requiredLevel}</p>
                                            </div>
                                        </li>
                                    ))}
                                </ul>
                            </div>
                        )}
                        {job.spells && job.spells.length > 0 && (
                            <div>
                                <h3>Spells</h3>
                                <ul>
                                    {job.spells.map((spell) => (
                                        <li key={spell.id || spell.name}>
                                            <div>
                                                <strong>{spell.name}</strong>
                                                <p>Description: {spell.description}</p>
                                                <p>Cooldown: {spell.cooldown}</p>
                                                <p>Casting Time: {spell.castTime}</p>
                                                <p>Mana Cost: {spell.manaCost}</p>
                                                <p>Potency: {spell.potency}</p>
                                                <p>Required Level: {spell.requiredLevel}</p>
                                            </div>
                                        </li>
                                    ))}
                                </ul>
                            </div>
                        )}
                    </li>
                ))}
            </ul>
        </div>
    );
};

export default Test;
