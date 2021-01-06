﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;



namespace testgame {
    public class Zone : World {
        public Zone() {

        }
        public Zone(Vector2 vector, WorldGraphics graphics, List<Char> currentCharacters, PC pc) {
            this.vector = vector;
            this.graphics = graphics;
            currCharacters = currentCharacters;
            this.pc = pc;
        }

        public void Move(KeyboardState state) {

            if (vector.X - pc.moveSpeed >= graphics.resX - graphics.texture.Width && state.IsKeyDown(Keys.D) && pc.vector.X >= graphics.resX / 2 - pc.graphics.texture.Width / 2) {
                vector.X -= pc.moveSpeed;
            } else if (pc.vector.X + pc.moveSpeed <= graphics.resX - pc.graphics.texture.Width && state.IsKeyDown(Keys.D)) {
                pc.vector.X += pc.moveSpeed;
            }
            if (vector.X + pc.moveSpeed <= 0 && state.IsKeyDown(Keys.A) && pc.vector.X <= graphics.resX / 2 - pc.graphics.texture.Width / 2) {
                vector.X += pc.moveSpeed;
            } else if (pc.vector.X >= 0 && state.IsKeyDown(Keys.A)) {
                pc.vector.X -= pc.moveSpeed;
            }
            if (vector.Y - pc.moveSpeed >= graphics.resY - graphics.texture.Height && state.IsKeyDown(Keys.S) && pc.vector.Y >= graphics.resY / 2 - pc.graphics.texture.Height) {
                vector.Y -= pc.moveSpeed;
            } else if (pc.vector.Y + pc.moveSpeed <= (graphics.resY - pc.graphics.texture.Height) && state.IsKeyDown(Keys.S)) {
                pc.vector.Y += pc.moveSpeed;
            }
            if (vector.Y + pc.moveSpeed <= 0 && state.IsKeyDown(Keys.W) && pc.vector.Y <= graphics.resY / 2 - pc.graphics.texture.Height / 2) {
                vector.Y += pc.moveSpeed;
            } else if (pc.vector.Y - pc.moveSpeed >= 0 && state.IsKeyDown(Keys.W)) {
                pc.vector.Y -= pc.moveSpeed;
            }
        }

    }
}
