import React, { useState } from 'react';

const Demo = () => {
    const [isHovering, setIsHovering] = useState(false);

    const handleMouseOver = () => {
        setIsHovering(true);
    };

    const handleMouseOut = () => {
        setIsHovering(false);
    };
    return (
        <div>
          <div>
            <div onMouseOver={handleMouseOver} onMouseOut={handleMouseOut}>
              Hover over me
            </div>
            {isHovering && (
              <div>
                <h2>Only visible when hovering div</h2>
              </div>
            )}
          </div>
        </div>
  );
}

export default Demo